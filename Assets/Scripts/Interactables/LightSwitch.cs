using UnityEngine;

public class LightSwitch : Interactable
{
    [SerializeField] private string blockedMessage = "Better get my job done.";
    [SerializeField] private string leaveOfficeMessage = "I should leave the office now.";

    private void Start()
    {
        isInteractable = true;
    }

    protected override void Interact()
    {
        if (DayManager.Instance == null) return;

        DayState state = DayManager.Instance.CurrentDayState;

        if (state == DayState.Idle)
        {
            if (DayManager.Instance.CanLeaveOffice)
            {
                ShowMessage(leaveOfficeMessage);
                return;
            }

            DayManager.Instance.StartDay();
            return;
        }

        if (state == DayState.DayEnded)
        {
            DayManager.Instance.EndDay();
            return;
        }

        if (state == DayState.Working || state == DayState.Reviewing)
        {
            ShowMessage(blockedMessage);
            return;
        }
    }

    public void SetInteractable(bool value)
    {
        // Always keep it interactable so blocked interactions can show feedback.
        isInteractable = true;
    }

    private void ShowMessage(string message)
    {
        if (ScreenMessageUI.Instance != null)
        {
            ScreenMessageUI.Instance.ShowMessage(message);
        }
        else
        {
            Debug.Log(message);
        }
    }
}