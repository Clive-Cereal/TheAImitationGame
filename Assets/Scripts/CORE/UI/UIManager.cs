using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Text;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

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
    [SerializeField] private TMP_Text documentTypeText;
    [SerializeField] private TMP_Text documentDOBText;
    [SerializeField] private TMP_Text documentNatText;
    [SerializeField] private TMP_Text documentDeclText;
    [SerializeField] private TMP_Text documentExpiryText;
    [SerializeField] private TMP_Text documentCyberwareText;

[Header("HUD")]
    [SerializeField] private TMP_Text warningText;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text dayText;

    [Header("Pause Menu")]
    [SerializeField] private GameObject pauseMenu;



    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;

        dialoguePanel.SetActive(false);
        reviewPanel.SetActive(false);
        pauseMenu.SetActive(false);

}

    public void OnApproveClicked()    => DayManager.Instance.OnApprove();
    public void OnRejectClicked()     => DayManager.Instance.OnReject();
    public void OnExitReviewClicked() => DayManager.Instance.ExitReview();

    public void ToggleDocuments()
    {
        documentSection.SetActive(!documentSection.activeSelf);
    }

    // THIS MAKES DIALOGUE-------------------------------------------------------------------------
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
        dayText.text = $"Day {day}";
    }

    //── Pause ───────────────────────────────────────────────────────────────────

    private PlayerController _playerController;

    private void Start()
    {
        _playerController = FindFirstObjectByType<PlayerController>();
        if (_playerController != null)
            _playerController.OnPausePressed += PauseGame;
    }

    private void OnDestroy()
    {
        if (_playerController != null)
            _playerController.OnPausePressed -= PauseGame;
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
