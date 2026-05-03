using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBedroom : Interactable
{
    [SerializeField] private string targetSceneName = "04_Bedroom";

    private void Start()
    {
        isInteractable = true;
    }

    protected override void Interact()
    {
        if (GameManager.Instance != null)
            GameManager.Instance.SceneLoader(targetSceneName, GameState.Playing);
        else
            SceneManager.LoadScene(targetSceneName);
    }
}