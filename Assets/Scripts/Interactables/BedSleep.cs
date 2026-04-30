using UnityEngine;

public class BedSleep : Interactable
{
    [SerializeField] private GoToWork goToWorkButton;

    private bool hasSlept = false;

    protected override void Interact()
    {
        if (hasSlept) return;

        hasSlept = true;
        isInteractable = false;

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