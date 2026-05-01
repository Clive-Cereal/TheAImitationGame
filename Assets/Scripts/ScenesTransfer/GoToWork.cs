using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWork : Interactable
{
    [SerializeField] private string targetSceneName = "02_Main";
    [SerializeField] private string tiredMessage = "I'm tired, better get some rest.";

    private bool canGoToWork = false;

    private void Start()
    {
        // Keep this interactable so the player can press it and get feedback.
        isInteractable = true;
    }

    public void SetInteractable(bool value)
    {
        // This now controls whether the player is allowed to go to work,
        // not whether the button can receive interaction.
        canGoToWork = value;
        isInteractable = true;
    }

    protected override void Interact()
    {
        if (!canGoToWork)
        {
            if (ScreenMessageUI.Instance != null)
            {
                ScreenMessageUI.Instance.ShowMessage(tiredMessage);
            }
            else
            {
                Debug.Log(tiredMessage);
            }

            return;
        }

        if (GameManager.Instance != null)
        {
            GameManager.Instance.SceneLoader(targetSceneName, GameState.Playing);
        }
        else
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}