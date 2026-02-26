using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class ConversationUI : MonoBehaviour
{
    [Header("Dialogue Panel")]
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text npcNameText;
    [SerializeField] private TMP_Text npcDialogueText;
    [SerializeField] private TMP_Text playerNameText;
    [SerializeField] private TMP_Text playerDialogueText;

    [Header("Review Panel Root")]
    [SerializeField] private GameObject reviewPanel;

    [Header("Document Section")]
    [SerializeField] private GameObject documentSection;
    [SerializeField] private Button toggleDocumentsButton;
    [SerializeField] private TMP_Text documentTypeText;
    [SerializeField] private TMP_Text documentDOBText;
    [SerializeField] private TMP_Text documentNatText;
    [SerializeField] private TMP_Text documentDeclText;
    [SerializeField] private TMP_Text documentExpiryText;
    [SerializeField] private TMP_Text documentCyberwareText;

    [Header("Decision Buttons")]
    [SerializeField] private Button approveButton;
    [SerializeField] private Button rejectButton;
    [SerializeField] private Button exitReviewButton;

    [Header("HUD")]
    [SerializeField] private TMP_Text warningText;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text dayText;

    private void Awake()
    {
        approveButton.onClick.AddListener(() => DayManager.Instance.OnApprove());
        rejectButton.onClick.AddListener(() => DayManager.Instance.OnReject());
        exitReviewButton.onClick.AddListener(() => DayManager.Instance.ExitReview());
        toggleDocumentsButton.onClick.AddListener(ToggleDocuments);
        dialoguePanel.SetActive(false);
        reviewPanel.SetActive(false);
    }

    public void ToggleDocuments()
    {
        documentSection.SetActive(!documentSection.activeSelf);
    }

    public void ShowDialogue(string npcName, string npcLine, string playerLine = null)
    {
        npcNameText.text     = npcName;
        npcDialogueText.text = npcLine;

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

    // ── Border subject review ─────────────────────────────────────────────────
    public void ShowSubject(Subject s)
    {
        ShowDialogue(s.displayName, s.purposeDialogue, "What is the purpose of your visit?");

        Document doc = s.document;

        documentTypeText.text = doc._isRobot ? "Type: ROBOT" : "Type: HUMAN";
        documentDOBText.text  = $"Date of Birth: {doc._dateofbirth}";
        documentNatText.text  = $"Nationality: {doc._nationality}";

        if (doc._declaration != null && doc._declaration.Count > 0)
        {
            StringBuilder sb = new StringBuilder("Declared: ");
            foreach (var item in doc._declaration)
            {
                sb.Append(item);
                if (item == DeclarationItem.Medication)
                    sb.Append($" ({doc.medicationDetail.name}, {doc.medicationDetail.manufacturer})");
                else if (item == DeclarationItem.SpecialSubstance)
                    sb.Append($" ({doc.substanceDetail.name}, {doc.substanceDetail.manufacturer})");
                sb.Append("  ");
            }
            documentDeclText.text = sb.ToString().TrimEnd();
        }
        else
        {
            documentDeclText.text = "Declared: Nothing";
        }

        if (doc.isExpired)
            documentExpiryText.text = $"<color=red>EXPIRED  ({doc.expiryYear})</color>";
        else
            documentExpiryText.text = $"Valid until: {doc.expiryYear}";

        if (documentCyberwareText != null)
        {
            if (doc.cyberware != null && doc.cyberware.Count > 0)
            {
                StringBuilder cw = new();
                foreach (var implant in doc.cyberware)
                {
                    string status = implant.isApproved
                        ? "APPROVED"
                        : "<color=red>DISAPPROVED</color>";
                    cw.AppendLine($"[{implant.implantID}]  {implant.installYear}  |  {implant.type}  |  {implant.manufacturer}");
                    cw.AppendLine($"  Purpose: {implant.purpose}  |  {status}");
                }
                documentCyberwareText.text = cw.ToString().TrimEnd();
            }
            else
            {
                documentCyberwareText.text = "Cyberware: None";
            }
        }

        documentSection.SetActive(true);
        reviewPanel.SetActive(true);
    }

    public void HidePanel()
    {
        reviewPanel.SetActive(false);
        dialoguePanel.SetActive(false);
    }

    // ── HUD ───────────────────────────────────────────────────────────────────
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
        dayText.text = $"Day {day + 1}";
    }


    //to do: interrogate function, fast travel + map exploration
}
