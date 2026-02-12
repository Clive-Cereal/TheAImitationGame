using UnityEngine;

public class SubjectExample : Interactable
{
    public GameObject skillcheckexample;
    protected override void Interact()
    {
        Debug.Log("Subject example interacted");
        skillcheckexample.SetActive(true);
    }
}
