using UnityEngine;
using System;
using System.Collections.Generic;

public class SubjectSpawner : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private GameObject[] humanPrefabs;
    [SerializeField] private GameObject[] robotPrefabs;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private Transform interactionPoint;
    [SerializeField] private Transform exitPoint;

    [Header("Spawn Probabilities")]
    [Tooltip("30% robot, 70% human by default.")]
    [SerializeField, Range(0f, 1f)] private float robotChance = 0.30f;

    [Tooltip("80% valid (correct docs), 20% invalid by default.")]
    [SerializeField, Range(0f, 1f)] private float validChance = 0.80f;

    [Header("Item Chances")]
    [SerializeField, Range(0f, 1f)] private float cyberwareChance  = 0.40f;
    [SerializeField, Range(0f, 1f)] private float medicationChance = 0.25f;
    [SerializeField, Range(0f, 1f)] private float substanceChance  = 0.10f;

   [SerializeField]public const int GameYear = 3157;

    private GameObject currentSubjectInstance;

    private static readonly Nationality[]           AllNationalities  = (Nationality[])Enum.GetValues(typeof(Nationality));
    private static readonly CyberwareType[]         AllCyberwareTypes = (CyberwareType[])Enum.GetValues(typeof(CyberwareType));
    private static readonly CyberwareManufacturer[] AllManufacturers = (CyberwareManufacturer[])Enum.GetValues(typeof(CyberwareManufacturer));

    public void SpawnSubject(Action<Subject> onArrived)
    {
        DestroyCurrentSubject();

        bool isRobot = UnityEngine.Random.value < robotChance;
        bool isValid = UnityEngine.Random.value < validChance;

        SubjectType subjectType = isRobot
            ? (isValid ? SubjectType.ValidRobot  : SubjectType.InvalidRobot)
            : (isValid ? SubjectType.ValidHuman  : SubjectType.InvalidHuman);

        InvalidCause cause = isValid ? InvalidCause.None : RollInvalidCause();

        GameObject[] pool = isRobot ? robotPrefabs : humanPrefabs;
        if (pool == null || pool.Length == 0)
        {
            Debug.LogWarning($"SubjectSpawner: {(isRobot ? "robotPrefabs" : "humanPrefabs")} is empty.");
            return;
        }

        currentSubjectInstance = Instantiate(
            pool[UnityEngine.Random.Range(0, pool.Length)],
            spawnPoint.position, spawnPoint.rotation);

        Subject          subject   = currentSubjectInstance.GetComponent<Subject>();
        Document         document  = currentSubjectInstance.GetComponent<Document>();
        SubjectProcessor processor = currentSubjectInstance.GetComponent<SubjectProcessor>();

        if (subject == null || document == null || processor == null)
        {
            Debug.LogError($"SubjectSpawner: prefab '{currentSubjectInstance.name}' is missing " +
                           $"Subject={subject != null}, Document={document != null}, SubjectProcessor={processor != null}. " +
                           "Add all three components to the prefab.");
            Destroy(currentSubjectInstance);
            currentSubjectInstance = null;
            return;
        }

        int   trueDOB = isRobot ? UnityEngine.Random.Range(3110, GameYear) : UnityEngine.Random.Range(3060, 3130);
        float height  = isRobot ? UnityEngine.Random.Range(1.5f, 2.5f)    : UnityEngine.Random.Range(1.55f, 1.95f);
        float weight  = isRobot ? UnityEngine.Random.Range(60f, 200f)     : UnityEngine.Random.Range(50f, 110f);
        Nationality nat = AllNationalities[UnityEngine.Random.Range(0, AllNationalities.Length)];

        string displayName   = DialogueLibrary.Names[UnityEngine.Random.Range(0, DialogueLibrary.Names.Length)];
        string dialogue      = (isRobot ? DialogueLibrary.RobotPurpose : DialogueLibrary.HumanPurpose)
                               [UnityEngine.Random.Range(0, isRobot ? DialogueLibrary.RobotPurpose.Length : DialogueLibrary.HumanPurpose.Length)];

        bool docIsRobot = isRobot;
        bool docExpired = false;
        int  expiryYear = GameYear + UnityEngine.Random.Range(1, 25);

        var declarations = new List<DeclarationItem>();
        var cyberwareList = new List<Cyberware>();
        MedicationProduct      medDetail = default;
        SpecialSubstanceProduct subDetail = default;

        switch (cause)
        {
            case InvalidCause.DocumentMismatch:
                docIsRobot = !isRobot;
                break;

            case InvalidCause.ExpiredDocument:
                docExpired = true;
                expiryYear = GameYear - UnityEngine.Random.Range(1, 20);
                break;

            case InvalidCause.ProhibitedItem:
                AddProhibitedItem(declarations, ref medDetail, ref subDetail);
                break;

            case InvalidCause.DisapprovedCyberware:
                cyberwareList.Add(GenerateCyberware(approved: false));
                break;
        }

        if (cyberwareList.Count == 0 && UnityEngine.Random.value < cyberwareChance)
            cyberwareList.Add(GenerateCyberware(approved: true));

        if (cyberwareList.Count > 0 && UnityEngine.Random.value < 0.3f)
            cyberwareList.Add(GenerateCyberware(approved: true));

        if (cause != InvalidCause.ProhibitedItem)
            AddLegalItems(declarations, ref medDetail, ref subDetail);

        float bioBase = isRobot ? UnityEngine.Random.Range(70f, 95f) : UnityEngine.Random.Range(0f, 5f);
        float metBase = isRobot ? UnityEngine.Random.Range(50f, 85f) : UnityEngine.Random.Range(1f, 4f);
        foreach (var cw in cyberwareList)
        {
            bioBase += UnityEngine.Random.Range(4f, 12f);
            if (cw.type == CyberwareType.LimbReplacement || cw.type == CyberwareType.SpinalBrace)
                metBase += UnityEngine.Random.Range(8f, 18f);
        }

        subject.isRobot         = isRobot;
        subject.subjectType     = subjectType;
        subject.invalidCause    = cause;
        subject.displayName     = displayName;
        subject.purposeDialogue = dialogue;
        subject.dateofbirth     = trueDOB;
        subject.nationality     = nat;
        subject.height          = height;
        subject.weight          = weight;
        subject.bionicPercent   = Mathf.Clamp(bioBase, 0f, 100f);
        subject.metalPercent    = Mathf.Clamp(metBase, 0f, 100f);

        document._isRobot         = docIsRobot;
        document._dateofbirth     = trueDOB;
        document._nationality     = nat;
        document.isExpired        = docExpired;
        document.expiryYear       = expiryYear;
        document._declaration     = declarations;
        document.medicationDetail = medDetail;
        document.substanceDetail  = subDetail;
        document.cyberware        = cyberwareList;
        subject.document          = document;

        Subject captured = subject;
        processor.MoveTo(interactionPoint.position, () => onArrived?.Invoke(captured));
    }

    public void SendSubjectAway()
    {
        if (currentSubjectInstance == null) return;
        SubjectProcessor processor = currentSubjectInstance.GetComponent<SubjectProcessor>();
        if (processor != null) processor.LeaveAndDestroy(exitPoint.position);
        currentSubjectInstance = null;
    }

    public void DestroyCurrentSubject()
    {
        if (currentSubjectInstance != null)
        {
            Destroy(currentSubjectInstance);
            currentSubjectInstance = null;
        }
    }

    private InvalidCause RollInvalidCause()
    {
        switch (UnityEngine.Random.Range(0, 4))
        {
            case 0:  return InvalidCause.DocumentMismatch;
            case 1:  return InvalidCause.ExpiredDocument;
            case 2:  return InvalidCause.ProhibitedItem;
            default: return InvalidCause.DisapprovedCyberware;
        }
    }

    private void AddProhibitedItem(List<DeclarationItem> decl,
                                   ref MedicationProduct med,
                                   ref SpecialSubstanceProduct sub)
    {
        switch (UnityEngine.Random.Range(0, 3))
        {
            case 0:
                decl.Add(DeclarationItem.GradeCWeapon);
                break;
            case 1:
                decl.Add(DeclarationItem.SpecialSubstance);
                sub = ItemLibrary.SpecialSubstances[
                    UnityEngine.Random.Range(0, ItemLibrary.SpecialSubstances.Length)];
                break;
            default:
                var narcotic = FindNarcotic();
                if (narcotic.HasValue)
                {
                    decl.Add(DeclarationItem.Medication);
                    med = narcotic.Value;
                }
                else
                {
                    decl.Add(DeclarationItem.GradeCWeapon);
                }
                break;
        }
    }

    private void AddLegalItems(List<DeclarationItem> decl,
                                ref MedicationProduct med,
                                ref SpecialSubstanceProduct sub)
    {
        if (UnityEngine.Random.value < medicationChance)
        {
            decl.Add(DeclarationItem.Medication);
            med = PickLegalMedication();
        }
        if (UnityEngine.Random.value < substanceChance)
        {
            var legalSubs = new List<SpecialSubstanceProduct>();
            foreach (var s in ItemLibrary.SpecialSubstances)
                if (s.type == SpecialSubstanceType.IndustrialSolvent ||
                    s.type == SpecialSubstanceType.BioActivator       ||
                    s.type == SpecialSubstanceType.NeuralFluid)
                    legalSubs.Add(s);
            if (legalSubs.Count > 0)
            {
                decl.Add(DeclarationItem.SpecialSubstance);
                sub = legalSubs[UnityEngine.Random.Range(0, legalSubs.Count)];
            }
        }
        if (UnityEngine.Random.value < 0.15f) decl.Add(DeclarationItem.Food);
        if (UnityEngine.Random.value < 0.10f) decl.Add(DeclarationItem.GradeAWeapon);
    }

    private MedicationProduct PickLegalMedication()
    {
        var legal = new List<MedicationProduct>();
        foreach (var m in ItemLibrary.Medications)
            if (m.type != MedicationType.Sedative && m.type != MedicationType.Neurosuppressant)
                legal.Add(m);
        return legal.Count > 0
            ? legal[UnityEngine.Random.Range(0, legal.Count)]
            : ItemLibrary.Medications[0];
    }

    private MedicationProduct? FindNarcotic()
    {
        var narcotics = new List<MedicationProduct>();
        foreach (var m in ItemLibrary.Medications)
            if (m.type == MedicationType.Sedative || m.type == MedicationType.Neurosuppressant)
                narcotics.Add(m);
        return narcotics.Count > 0
            ? narcotics[UnityEngine.Random.Range(0, narcotics.Count)]
            : (MedicationProduct?)null;
    }

    private Cyberware GenerateCyberware(bool approved)
    {
        CyberwareType        cwType  = AllCyberwareTypes[UnityEngine.Random.Range(0, AllCyberwareTypes.Length)];
        CyberwareManufacturer mfr    = AllManufacturers[UnityEngine.Random.Range(0, AllManufacturers.Length)];
        string purpose               = ItemLibrary.CyberwarePurposes[UnityEngine.Random.Range(0, ItemLibrary.CyberwarePurposes.Length)];
        return new Cyberware
        {
            implantID    = GenerateImplantID(cwType),
            installYear  = UnityEngine.Random.Range(GameYear - 30, GameYear),
            type         = cwType,
            manufacturer = mfr,
            purpose      = purpose,
            isApproved   = approved
        };
    }

    private string GenerateImplantID(CyberwareType type)
    {
        string prefix = type switch
        {
            CyberwareType.NeuralInterface  => "NI",
            CyberwareType.OpticalAugment   => "OA",
            CyberwareType.LimbReplacement  => "LR",
            CyberwareType.CardiacRegulator => "CR",
            CyberwareType.SpinalBrace      => "SB",
            CyberwareType.MemoryExpansion  => "ME",
            CyberwareType.VoiceSynthesizer => "VS",
            CyberwareType.NeuralRelay      => "NR",
            CyberwareType.ReflexStabilizer => "RS",
            _                              => "CW"
        };
        return $"{prefix}-{UnityEngine.Random.Range(1000, 9999)}-{(char)('A' + UnityEngine.Random.Range(0, 26))}";
    }
}
