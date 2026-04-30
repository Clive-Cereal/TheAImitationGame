using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Subject))]
public class NPCInteractable : Interactable
{
    private static readonly int IsTalking = Animator.StringToHash("isTalking");

    private Animator _anim;
    private Subject  _subject;
    private int      _index = -1;

    public string[] lines;

    private void Start()
    {
        _anim    = GetComponent<Animator>();
        _subject = GetComponent<Subject>();
    }

    protected override void Interact()
    {
        if (lines == null || lines.Length == 0) return;

        _index++;

        if (_index >= lines.Length)
        {
            _index = -1;
            _anim.SetBool(IsTalking, false);
            UIManager.Instance.HideDialogue();
            return;
        }

        _anim.SetBool(IsTalking, true);
        UIManager.Instance.ShowDialogue(_subject.displayName, lines[_index]);
    }
}
