using UnityEngine;

public class SubjectInteractable : Interactable
{
    protected override void Interact()
    {
        if (DayManager.Instance == null) return;
        Debug.Log($"SubjectInteractable hit. DayState={DayManager.Instance.CurrentDayState}");
        DayManager.Instance.StartReview();
    }
}
