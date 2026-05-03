using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Dialogue Panel")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private Image characterPortrait;
    [SerializeField] private TMP_Text npcNameText;
    [SerializeField] private TMP_Text npcDialogueText;
    [SerializeField] private TMP_Text playerNameText;
    [SerializeField] private TMP_Text playerDialogueText;

    [Header("Review Panel Root")]
    [SerializeField] private GameObject reviewPanel;

    [Header("ID Card Section")]
    [SerializeField] private GameObject idCardSection;
    [SerializeField] private TMP_Text idCardNameText;
    [SerializeField] private TMP_Text idCardNumberText;
    [SerializeField] private TMP_Text idCardDOBText;
    [SerializeField] private TMP_Text idCardCityText;
    [SerializeField] private TMP_Text idCardExpiryText;

    [Header("Certificate Section (ARC)")]
    [SerializeField] private GameObject certificateSection;
    [SerializeField] private TMP_Text certNameText;
    [SerializeField] private TMP_Text certDOBText;
    [SerializeField] private TMP_Text certIdText;
    [SerializeField] private TMP_Text certCityText;
    [SerializeField] private TMP_Text certExpiryText;
    [SerializeField] private TMP_Text certDeclText;
    [SerializeField] private TMP_Text certCyberwareText;

    [Header("HUD")]
    [SerializeField] private TMP_Text warningText;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text dayText;

    [Header("Pause Menu")]
    [SerializeField] private GameObject pauseMenu;

    [Header("Main Scene Only Buttons")]
    [SerializeField] private Button toggleDocumentsButton;
    [SerializeField] private Button exitReviewButton;
    [SerializeField] private Button approveButton;
    [SerializeField] private Button rejectButton;

    private const string MainSceneName = "02_Main";

    private PlayerController _playerController;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        dialoguePanel.SetActive(false);
        reviewPanel.SetActive(false);
        pauseMenu.SetActive(false);
        if (certificateSection != null) certificateSection.SetActive(false);

        SceneManager.sceneLoaded += OnSceneLoaded;
        SetMainSceneButtons(SceneManager.GetActiveScene().name == MainSceneName);

        // Wire up for the initial scene (OnSceneLoaded won't fire for the first scene)
        _playerController = FindFirstObjectByType<PlayerController>();
        if (_playerController != null)
            _playerController.OnPausePressed += PauseGame;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        SetMainSceneButtons(scene.name == MainSceneName);

        // Unsubscribe from the old (destroyed) PlayerController, then find the new one
        if (_playerController != null)
            _playerController.OnPausePressed -= PauseGame;

        _playerController = FindFirstObjectByType<PlayerController>();
        if (_playerController != null)
            _playerController.OnPausePressed += PauseGame;
    }

    private void SetMainSceneButtons(bool enabled)
    {
        if (toggleDocumentsButton != null) toggleDocumentsButton.interactable = enabled;
        if (exitReviewButton     != null) exitReviewButton.interactable      = enabled;
        if (approveButton        != null) approveButton.interactable         = enabled;
        if (rejectButton         != null) rejectButton.interactable          = enabled;
    }

    private void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
        if (_playerController != null)
            _playerController.OnPausePressed -= PauseGame;
    }

    public void OnApproveClicked()    => DayManager.Instance.OnApprove();
    public void OnRejectClicked()     => DayManager.Instance.OnReject();
    public void OnExitReviewClicked() => DayManager.Instance.ExitReview();

    public void ToggleDocuments()
    {
        bool show = !idCardSection.activeSelf;
        idCardSection.SetActive(show);
        if (certificateSection != null) certificateSection.SetActive(show);
    }

    public void ShowDialogue(string npcName, string npcLine, string playerLine = null, Sprite portrait = null)
    {
        npcNameText.text     = npcName;
        npcDialogueText.text = npcLine;

        if (characterPortrait != null)
        {
            characterPortrait.gameObject.SetActive(portrait != null);
            if (portrait != null) characterPortrait.sprite = portrait;
        }

        bool showPlayer = playerLine != null && playerNameText != null && playerDialogueText != null;
        if (playerNameText != null)     playerNameText.gameObject.SetActive(showPlayer);
        if (playerDialogueText != null) playerDialogueText.gameObject.SetActive(showPlayer);
        if (showPlayer)
        {
            playerNameText.text     = "You";
            playerDialogueText.text = playerLine;
        }

        dialoguePanel.SetActive(true);
    }

    public void HideDialogue()
    {
        dialoguePanel.SetActive(false);
    }

    public void ShowSubject(Subject s)
    {
        ShowDialogue(s.displayName, s.purposeDialogue, "What is the purpose of your visit?");

        IDCard doc = s.document;
        idCardNameText.text   = s.displayName;
        idCardNumberText.text = doc.idNumber;
        idCardDOBText.text    = doc._dateofbirth;
        idCardCityText.text   = NatToCity(doc._nationality);

        idCardExpiryText.text = doc.isExpired
            ? $"<color=red>{doc.expiryYear}  [EXPIRED]</color>"
            : doc.expiryYear.ToString();

        idCardSection.SetActive(true);

        Certificate cert = s.certificate;
        if (cert != null)
        {
            certNameText.text = cert.displayName;
            certDOBText.text  = cert.dateOfBirth;
            certIdText.text   = cert.idNumber;
            certCityText.text   = NatToCity(cert.city);
            certExpiryText.text = doc.isExpired
                ? $"<color=red>{doc.expiryYear}  [EXPIRED]</color>"
                : doc.expiryYear.ToString();

            if (certDeclText != null)
            {
                IDCard card = s.document;
                if (card != null && card._declaration != null && card._declaration.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in card._declaration)
                    {
                        sb.Append(item);
                        if (item == DeclarationItem.Medication)
                            sb.Append($" ({card.medicationDetail.name}, {card.medicationDetail.manufacturer})");
                        else if (item == DeclarationItem.SpecialSubstance)
                            sb.Append($" ({card.substanceDetail.name}, {card.substanceDetail.manufacturer})");
                        sb.Append("  ");
                    }
                    certDeclText.text = sb.ToString().TrimEnd();
                }
                else
                {
                    certDeclText.text = "Nothing";
                }
            }

            if (cert.cyberware != null && cert.cyberware.Count > 0)
            {
                StringBuilder cw = new();
                cw.AppendLine("IMPLANT ID              DATE                  TYPE             MANUFACTURER     PURPOSE          STATUS");
                foreach (var implant in cert.cyberware)
                {
                    string status = implant.isApproved ? "Approved" : "<color=red>Disapproved</color>";
                    cw.AppendLine($"{implant.implantID,-15} {implant.installDate,-11} {FormatCyberwareType(implant.type),-23} {FormatManufacturer(implant.manufacturer),-25} {implant.purpose,-16} {status}");
                }
                certCyberwareText.text = $"<mspace=0.55em>{cw.ToString().TrimEnd()}</mspace>";
            }
            else
            {
                certCyberwareText.text = "No registered augmentations.";
            }

            certificateSection.SetActive(true);
        }

        reviewPanel.SetActive(true);
    }

    public void HidePanel()
    {
        reviewPanel.SetActive(false);
        dialoguePanel.SetActive(false);
        if (idCardSection != null) idCardSection.SetActive(false);
        if (certificateSection != null) certificateSection.SetActive(false);
    }

    private static string NatToCity(Nationality n) => n switch
    {
        Nationality.Arder => "ARDOR",
        Nationality.Dime  => "DIME",
        _                 => n.ToString().ToUpper()
    };

    private static string FormatCyberwareType(CyberwareType t) => t switch
    {
        CyberwareType.NeuralInterface  => "Neural Interface",
        CyberwareType.OpticalAugment   => "Optical Augment",
        CyberwareType.LimbReplacement  => "Limb Replacement",
        CyberwareType.CardiacRegulator => "Cardiac Regulator",
        CyberwareType.SpinalBrace      => "Spinal Brace",
        CyberwareType.MemoryExpansion  => "Memory Expansion",
        CyberwareType.VoiceSynthesizer => "Voice Synthesizer",
        CyberwareType.NeuralRelay      => "Neural Relay",
        CyberwareType.ReflexStabilizer => "Reflex Stabilizer",
        _                              => t.ToString()
    };

    private static string FormatManufacturer(CyberwareManufacturer m) => m switch
    {
        CyberwareManufacturer.SynapetchIndustries => "Synaptech Industries",
        CyberwareManufacturer.HorcrowCorporation  => "Harcrow Corporation",
        CyberwareManufacturer.AxiomCorp           => "Axiom Corp",
        CyberwareManufacturer.NeuroplexSystems    => "Neuroplex Systems",
        CyberwareManufacturer.BioForge            => "BioForge",
        _                                         => m.ToString()
    };

    public void UpdateTimer(float elapsed)
    {
        int mins = Mathf.FloorToInt(elapsed / 60f);
        int secs = Mathf.FloorToInt(elapsed % 60f);
        timerText.text = $"Elapsed: {mins:00}:{secs:00}";
    }

    public void UpdateWarnings(int count)
    {
        warningText.text = $"Warnings: {count} / 3";
    }

    public void UpdateDay(int day)
    {
        dayText.text = $"Day {day}";
    }

    void PauseGame()
    {
        if (GameManager.currentState != GameState.Playing && GameManager.currentState != GameState.Paused) return;

        bool willPause = GameManager.currentState != GameState.Paused;
        GameManager.currentState = willPause ? GameState.Paused : GameState.Playing;
        pauseMenu.SetActive(willPause);
        Time.timeScale           = willPause ? 0f : 1f;
        Cursor.lockState         = willPause ? CursorLockMode.None   : CursorLockMode.Locked;
        Cursor.visible           = willPause;
    }
}