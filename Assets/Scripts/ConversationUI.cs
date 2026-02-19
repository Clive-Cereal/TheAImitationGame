using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Text;

public class ConversationUI : MonoBehaviour
{
    [Header("Review Panel Root")]
    [SerializeField] private GameObject reviewPanel;

    [Header("Dialogue")]
    [SerializeField] private TMP_Text subjectNameText;
    [SerializeField] private TMP_Text dialogueText;

    [Header("Document")]
    [SerializeField] private TMP_Text documentTypeText;
    [SerializeField] private TMP_Text documentDOBText;
    [SerializeField] private TMP_Text documentNatText;
    [SerializeField] private TMP_Text documentDeclText;

    [Header("Decision Buttons")]
    [SerializeField] private Button approveButton;
    [SerializeField] private Button rejectButton;

    [Header("HUD")]
    [SerializeField] private TMP_Text warningText;
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private TMP_Text dayText;

    private void Awake()
    {
        approveButton.onClick.AddListener(() => DayManager.Instance.OnApprove());
        rejectButton.onClick.AddListener(() => DayManager.Instance.OnReject());
        reviewPanel.SetActive(false);
    }

    public void ShowSubject(Subject s)
    {
        subjectNameText.text = s.displayName;
        dialogueText.text    = s.purposeDialogue;

        Document doc = s.document;
        documentTypeText.text = doc._isRobot ? "Type: ROBOT" : "Type: HUMAN";
        documentDOBText.text  = $"Date of Birth: {doc._dateofbirth}";
        documentNatText.text  = $"Nationality: {doc._nationality}";

        if (doc._declaration != null && doc._declaration.Count > 0)
        {
            StringBuilder sb = new StringBuilder("Declared: ");
            foreach (var item in doc._declaration)
                sb.Append(item).Append(", ");
            documentDeclText.text = sb.ToString().TrimEnd(',', ' ');
        }
        else
        {
            documentDeclText.text = "Declared: Nothing";
        }

        reviewPanel.SetActive(true);
    }

    public void HidePanel()
    {
        reviewPanel.SetActive(false);
    }

    public void UpdateTimer(float remaining)
    {
        int mins = Mathf.FloorToInt(remaining / 60f);
        int secs = Mathf.FloorToInt(remaining % 60f);
        timerText.text = $"Time: {mins:00}:{secs:00}";
    }

    public void UpdateWarnings(int count)
    {
        warningText.text = $"Warnings: {count} / 3";
    }

    public void UpdateDay(int day)
    {
        dayText.text = $"Day {day + 1}";
    }
}
