using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveOffice : Interactable
{
    [SerializeField] private string targetSceneName = "03_ParkNeighbourhood";

    private void Start()
    {
        isInteractable = false;

        if (DayManager.Instance != null)
        {
            DayManager.Instance.OnDayStarted += LockButton;
            DayManager.Instance.OnDayEnded += UnlockButton;
        }
    }

    private void OnDestroy()
    {
        if (DayManager.Instance != null)
        {
            DayManager.Instance.OnDayStarted -= LockButton;
            DayManager.Instance.OnDayEnded -= UnlockButton;
        }
    }

    private void LockButton()
    {
        isInteractable = false;
    }

    private void UnlockButton()
    {
        isInteractable = true;
        Debug.Log("Leave office button unlocked.");
    }

    protected override void Interact()
    {
        SceneManager.LoadScene(targetSceneName);
    }
}