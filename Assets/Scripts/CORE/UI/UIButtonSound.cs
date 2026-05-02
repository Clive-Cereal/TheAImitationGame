using UnityEngine;
using UnityEngine.EventSystems;
using FMODUnity;

public class UIButtonSound : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
{
    [SerializeField] private EventReference hoverSound;
    [SerializeField] private EventReference clickSound;

    public void OnPointerEnter(PointerEventData _) => RuntimeManager.PlayOneShot(hoverSound);
    public void OnPointerClick(PointerEventData _) => RuntimeManager.PlayOneShot(clickSound);
}
