using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOutside : Interactable
{
    [SerializeField] private string targetSceneName = "03_ParkNeighbourhood";

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