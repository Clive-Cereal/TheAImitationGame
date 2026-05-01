using UnityEngine;

public class InteractableHighlighter : MonoBehaviour
{
    [Header("Highlight Objects")]
    [SerializeField] private GameObject[] highlightObjects;

    private bool isHighlighted = false;

    private void Awake()
    {
        SetHighlighted(false);
    }

    public void SetHighlighted(bool value)
    {
        if (isHighlighted == value) return;

        isHighlighted = value;

        foreach (GameObject obj in highlightObjects)
        {
            if (obj != null)
            {
                obj.SetActive(value);
            }
        }
    }
}