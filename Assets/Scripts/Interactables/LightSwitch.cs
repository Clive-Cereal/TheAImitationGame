using UnityEngine;

public class LightSwitch : Interactable
{
    [SerializeField] private string blockedMessage = "Better get my job done";
    [SerializeField] private string afterDayEndedMessage = "I should leave the office now.";

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
                ShowMessage(afterDayEndedMessage);
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

        ShowMessage(blockedMessage);
    }

    public void SetInteractable(bool value)
    {
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