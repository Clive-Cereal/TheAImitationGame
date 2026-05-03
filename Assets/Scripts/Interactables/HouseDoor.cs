using UnityEngine;

public class HouseDoor : Interactable
{
    protected override void Interact()
    {
        if (DayManager.Instance == null) return;

        DayState state = DayManager.Instance.CurrentDayState;
        if (state != DayState.DayEnded) return;
        string next = GameManager.currentGameMode == GameMode.Endless
            ? "04_Bedroom"
            : "03_ParkNeighbourhood";
        GameManager.Instance.SceneLoader(next, GameState.Playing);
    }

    public void SetInteractable(bool value)
    {
        isInteractable = value;
    }
}
