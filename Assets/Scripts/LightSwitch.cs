using UnityEngine;

public class LightSwitch : Interactable
{
    protected override void Interact()
    {
        if (DayManager.Instance == null) return;

        DayState state = DayManager.Instance.CurrentDayState;
        if (state == DayState.Idle)        DayManager.Instance.StartDay();
        else if (state == DayState.DayEnded) DayManager.Instance.EndDay();
    }

    public void SetInteractable(bool value)
    {
        isInteractable = value;
    }
}
