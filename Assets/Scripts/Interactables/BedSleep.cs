using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class BedSleep : Interactable
{
    [SerializeField] private GoToWork goToWorkButton;
    [SerializeField] private SleepTransitionUI sleepTransitionUI;

    [TextArea]
    [SerializeField] private string sleepMessage =
        "After working all day, you were fast asleep in no time.";

    private bool hasSlept = false;

    protected override void Interact()
    {
        if (hasSlept) return;

        hasSlept = true;
        isInteractable = false;

        if (sleepTransitionUI != null)
        {
            sleepTransitionUI.PlaySleepTransition(
                sleepMessage,
                ApplySleepResult,
                UnlockGoToWork
            );
        }
        else
        {
            ApplySleepResult();
            UnlockGoToWork();
        }
    }

    private void ApplySleepResult()
    {   
        GameManager.Days++;


        

        if (GameManager.Instance != null)
        {
            GameManager.Instance.SaveGame();
        }
        else
        {
            Debug.LogWarning("No GameManager found. Day increased, but game was not saved.");
        }

        bool storyOver = GameManager.Days > GameManager.MaxDays
                         && GameManager.currentGameMode != GameMode.Endless;

        if (storyOver && GameManager.Instance != null)
        {
            GameManager.Instance.SceneLoader("05_Ending", GameState.Ending);
        }
    }

    private void UnlockGoToWork()
    {
        bool storyOver = GameManager.Days > GameManager.MaxDays
                         && GameManager.currentGameMode != GameMode.Endless;

        if (storyOver && GameManager.Instance != null)
        {
            return;
        }

        if (goToWorkButton != null)
        {
            goToWorkButton.SetInteractable(true);
            Debug.Log("Slept. GoToWork button unlocked.");
        }
        else
        {
            Debug.LogWarning("GoToWork button is not assigned on BedSleep.");
        }
    }
}