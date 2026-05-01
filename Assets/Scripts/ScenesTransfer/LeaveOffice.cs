using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveOffice : Interactable
{
    [SerializeField] private string targetSceneName = "03_ParkNeighbourhood";
    [SerializeField] private string blockedMessage = "Better get my job done.";

    private void Start()
    {
        // Keep it interactable so the player can receive feedback.
        isInteractable = true;
    }

    protected override void Interact()
    {
        if (DayManager.Instance == null)
        {
            ShowMessage(blockedMessage);
            return;
        }

        if (!DayManager.Instance.CanLeaveOffice)
        {
            ShowMessage(blockedMessage);
            return;
        }

        SceneManager.LoadScene(targetSceneName);
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