using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Text;

public class InspectionToolsManager : MonoBehaviour
{
    public static InspectionToolsManager Instance { get; private set; }

    [Header("Tool Panels")]
    [SerializeField] private GameObject tabletPanel;
    [SerializeField] private GameObject manualPanel;
    [SerializeField] private GameObject notepadPanel;

    [Header("Tablet Content")]
    [SerializeField] private TMP_Text tabletSubjectName;
    [SerializeField] private TMP_Text tabletBionicText;
    [SerializeField] private TMP_Text tabletMetalText;
    [SerializeField] private TMP_Text tabletItemsText;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); return; }
        Instance = this;

        tabletPanel.SetActive(false);
        manualPanel.SetActive(false);
        notepadPanel.SetActive(false);
    }

    // ── PlayerInput SendMessages callbacks ────────────────────────────────────
    private void OnTablet(InputValue _)  => Toggle(tabletPanel);
    private void OnManual(InputValue _)  => Toggle(manualPanel);
    private void OnNotepad(InputValue _) => Toggle(notepadPanel);

    // ── Toggle logic ──────────────────────────────────────────────────────────
    private void Toggle(GameObject target)
    {
        bool next = !target.activeSelf;

        tabletPanel.SetActive(false);
        manualPanel.SetActive(false);
        notepadPanel.SetActive(false);
        target.SetActive(next);

        bool anyOpen   = tabletPanel.activeSelf || manualPanel.activeSelf || notepadPanel.activeSelf;
        bool reviewing = DayManager.Instance != null &&
                         DayManager.Instance.CurrentDayState == DayState.Reviewing;
        bool needCursor = anyOpen || reviewing;

        Cursor.lockState = needCursor ? CursorLockMode.None  : CursorLockMode.Locked;
        Cursor.visible   = needCursor;
    }

    // ── Called by DayManager when a subject arrives ───────────────────────────
    public void PopulateTablet(Subject s)
    {
        if (tabletSubjectName != null) tabletSubjectName.text = s.displayName;
        if (tabletBionicText  != null) tabletBionicText.text  = $"Bionic Tissue:  {s.bionicPercent:F1} %";
        if (tabletMetalText   != null) tabletMetalText.text   = $"Metal Content:  {s.metalPercent:F1} %";

        if (tabletItemsText != null)
        {
            StringBuilder sb = new();
            if (s.document != null)
            {
                if (s.document.cyberware != null)
                    foreach (var cw in s.document.cyberware)
                        sb.AppendLine($"• {cw.type}  [{cw.manufacturer}]");

                if (s.document._declaration != null)
                    foreach (var d in s.document._declaration)
                        sb.AppendLine($"• {d}");
            }
            tabletItemsText.text = sb.Length > 0 ? sb.ToString().TrimEnd() : "Nothing detected.";
        }
    }

    public void CloseAll()
    {
        tabletPanel.SetActive(false);
        manualPanel.SetActive(false);
        notepadPanel.SetActive(false);
    }
}
