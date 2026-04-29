using UnityEngine;

public class BedInteractable : Interactable
{
    protected override void Interact()
    {
        if (DayManager.Instance == null) return;
        if (DayManager.Instance.CurrentDayState != DayState.DayEnded) return;

        GameManager.Days++;
        GameManager.Instance.SaveGame();

        bool storyOver = GameManager.Days > GameManager.MaxDays
                         && GameManager.currentGameMode != GameMode.Endless;

        if (storyOver)
            GameManager.Instance.SceneLoader("05_Ending", GameState.Ending);
        else
            GameManager.Instance.SceneLoader("02_Main", GameState.Playing);
    }
}
