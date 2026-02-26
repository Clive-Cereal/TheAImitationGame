using UnityEngine;

public class BedInteractable : Interactable
{
    protected override void Interact()
    {
        if (DayManager.Instance == null) return;
        if (DayManager.Instance.CurrentDayState != DayState.Idle) return;

        GameManager.Instance.SceneLoader("02_Main", GameState.Playing);
    }
}
