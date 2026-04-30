using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWork : Interactable
{
    [SerializeField] private string targetSceneName = "02_Main";

    private void Start()
    {
        isInteractable = false;
    }

    public void SetInteractable(bool value)
    {
        isInteractable = value;
    }

    protected override void Interact()
    {
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