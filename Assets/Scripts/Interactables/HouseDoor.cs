using UnityEngine;

public class HouseDoor : Interactable
{
    protected override void Interact()
    {
        if (DayManager.Instance == null) return;

        DayState state = DayManager.Instance.CurrentDayState;
        if (state != DayState.DayEnded) return;
        GameManager.Instance.SceneLoader("04_Bedroom", GameState.Playing);
    }

    public void SetInteractable(bool value)
    {
        isInteractable = value;
    }
}
