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
        SceneManager.LoadScene(targetSceneName);
    }
}