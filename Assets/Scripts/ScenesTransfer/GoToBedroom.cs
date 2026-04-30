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
        SceneManager.LoadScene(targetSceneName);
    }
}