using UnityEngine;

public class SubjectInteractable : Interactable
{
    protected override void Interact()
    {
        if (DayManager.Instance == null) return;
        DayManager.Instance.StartReview();
    }
}
