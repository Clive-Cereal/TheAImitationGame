using UnityEngine;
using TMPro;
using System.Text;

public class InspectionToolsManager : MonoBehaviour
{
    public static InspectionToolsManager Instance { get; private set; }

    private GameObject tabletPanel;
    private GameObject manualPanel;
    private GameObject notepadPanel;

    private TMP_Text       tabletSubjectName;
    private TMP_Text       tabletBionicText;
    private TMP_Text       tabletMetalText;
    private TMP_Text       tabletItemsText;
    private TMP_InputField notepadInput;

    private PlayerController _playerController;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(this); return; }
        Instance = this;

        tabletPanel  = FindIncludingInactive("Tablet");
        manualPanel  = FindIncludingInactive("Manual");
        notepadPanel = FindIncludingInactive("NotePad");

        if (tabletPanel != null)
        {
            Transform t;
            t = tabletPanel.transform.Find("tablet_Bionic"); if (t != null) tabletBionicText  = t.GetComponent<TMP_Text>();
            t = tabletPanel.transform.Find("tablet_Metal");  if (t != null) tabletMetalText   = t.GetComponent<TMP_Text>();
            t = tabletPanel.transform.Find("tablet_Name");   if (t != null) tabletSubjectName = t.GetComponent<TMP_Text>();
            t = tabletPanel.transform.Find("tablet_Items");  if (t != null) tabletItemsText   = t.GetComponent<TMP_Text>();
            tabletPanel.SetActive(false);
        }
        else Debug.LogError("InspectionToolsManager: could not find 'Tablet' panel in scene.", this);

        if (notepadPanel != null)
        {
            Transform t = notepadPanel.transform.Find("notepad_Input");
            if (t != null) notepadInput = t.GetComponent<TMP_InputField>();
            notepadPanel.SetActive(false);
        }

        if (manualPanel != null) manualPanel.SetActive(false);
    }

    private void Start()
    {
        _playerController = FindFirstObjectByType<PlayerController>();
        if (_playerController != null)
        {
            _playerController.OnTabletPressed  += ToggleTablet;
            _playerController.OnManualPressed  += ToggleManual;
            _playerController.OnNotepadPressed += ToggleNotepad;
        }

        if (notepadInput != null)
        {
            notepadInput.text = GameManager.NotepadContent;
            notepadInput.onValueChanged.AddListener(text => GameManager.NotepadContent = text);
        }
    }

    private void OnDestroy()
    {
        if (_playerController != null)
        {
            _playerController.OnTabletPressed  -= ToggleTablet;
            _playerController.OnManualPressed  -= ToggleManual;
            _playerController.OnNotepadPressed -= ToggleNotepad;
        }

        if (notepadInput != null)
            notepadInput.onValueChanged.RemoveAllListeners();
    }

    private void ToggleTablet()  => Toggle(tabletPanel);
    private void ToggleManual()  => Toggle(manualPanel);
    private void ToggleNotepad() => Toggle(notepadPanel);

    private void Toggle(GameObject target)
    {
        if (target == null) return;
        bool next = !target.activeSelf;

        tabletPanel.SetActive(false);
        manualPanel.SetActive(false);
        notepadPanel.SetActive(false);
        target.SetActive(next);

        bool anyOpen    = tabletPanel.activeSelf || manualPanel.activeSelf || notepadPanel.activeSelf;
        bool reviewing  = DayManager.Instance != null &&
                          DayManager.Instance.CurrentDayState == DayState.Reviewing;
        bool needCursor = anyOpen || reviewing;

        Cursor.lockState = needCursor ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible   = needCursor;
    }

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
        if (tabletPanel  != null) tabletPanel.SetActive(false);
        if (manualPanel  != null) manualPanel.SetActive(false);
        if (notepadPanel != null) notepadPanel.SetActive(false);
    }

    private static GameObject FindIncludingInactive(string name)
    {
        foreach (var t in FindObjectsByType<Transform>(FindObjectsInactive.Include, FindObjectsSortMode.None))
            if (t.name == name) return t.gameObject;
        return null;
    }
}
