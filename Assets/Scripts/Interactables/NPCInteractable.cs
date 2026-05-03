using UnityEngine;

public class NPCInteractable : Interactable
{
    public enum Mode { Dialogue, SubjectReview }

    [Header("Identity")]
    [Tooltip("Matched by ParkDayLoader to assign dialogue and location for the current day. Leave blank on subject prefabs.")]
    public string npcId;

    [Header("Mode")]
    [SerializeField] private Mode mode = Mode.Dialogue;

    [Header("Dialogue Settings")]
    [Tooltip("Fallback speaker name if a line's speaker field is blank. Leave blank to use Subject.displayName or the GameObject name.")]
    [SerializeField] private string npcName;
    [Tooltip("Portrait shown in the dialogue panel for this NPC. Individual lines can override this.")]
    [SerializeField] public Sprite portrait;
    [Tooltip("Lines cycled on each interact. Each entry has its own speaker. In SubjectReview mode, review triggers after the last line (or immediately if empty).")]
    [SerializeField] private DialogueLine[] lines;

    private static readonly int IsTalking = Animator.StringToHash("isTalking");
    private Animator _anim;
    private Subject  _subject;
    private int      _lineIndex = -1;

    private void Start()
    {
        _anim    = GetComponent<Animator>();
        _subject = GetComponent<Subject>();
    }

    protected override void Interact()
    {
        bool hasLines = lines != null && lines.Length > 0;

        if (mode == Mode.SubjectReview)
        {
            if (hasLines && _lineIndex < lines.Length - 1)
            {
                _lineIndex++;
                ShowLine();
            }
            else
            {
                _lineIndex = -1;
                if (_anim != null) _anim.SetBool(IsTalking, false);
                DayManager.Instance?.StartReview();
            }
            return;
        }

        // Dialogue mode
        if (!hasLines) return;

        _lineIndex++;
        if (_lineIndex >= lines.Length)
        {
            _lineIndex = -1;
            if (_anim != null) _anim.SetBool(IsTalking, false);
            UIManager.Instance.HideDialogue();
            return;
        }

        ShowLine();
    }

    public override void OnFocusLost()
    {
        if (_lineIndex < 0) return;
        _lineIndex = -1;
        if (_anim != null) _anim.SetBool(IsTalking, false);
        UIManager.Instance?.HideDialogue();
    }

    public void SetLines(DialogueLine[] newLines)
    {
        lines = newLines;
        _lineIndex = -1;
    }

    private void ShowLine()
    {
        DialogueLine line = lines[_lineIndex];

        string speaker = !string.IsNullOrWhiteSpace(line.speaker) ? line.speaker
                       : !string.IsNullOrWhiteSpace(npcName)      ? npcName
                       : _subject != null                          ? _subject.displayName
                       : gameObject.name;

        Sprite linePortrait = line.portrait != null ? line.portrait : portrait;

        if (_anim != null) _anim.SetBool(IsTalking, true);
        UIManager.Instance.ShowDialogue(speaker, line.text, portrait: linePortrait);
    }
}
