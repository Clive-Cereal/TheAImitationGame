using UnityEngine;
using UnityEngine.UI;

public class Manual : MonoBehaviour
{
    [SerializeField] private Image     display;
    [SerializeField] private GameObject contentsPanel;
    [SerializeField] private Sprite[]  pages;

    private const int ContentsPageIndex = 2; // page 3, zero-based

    private int _current;

    private void OnEnable()
    {
        _current = 0;
        ShowCurrent();
    }

    public void NextPage()
    {
        if (pages == null || pages.Length == 0) return;
        _current = Mathf.Min(_current + 1, pages.Length - 1);
        ShowCurrent();
    }

    public void PrevPage()
    {
        if (pages == null || pages.Length == 0) return;
        _current = Mathf.Max(_current - 1, 0);
        ShowCurrent();
    }

    // pageNumber is 1-based to match button labels
    public void JumpPage(int pageNumber)
    {
        if (pages == null || pages.Length == 0) return;
        _current = Mathf.Clamp(pageNumber - 1, 0, pages.Length - 1);
        ShowCurrent();
    }

    private void ShowCurrent()
    {
        if (display != null && pages != null && _current < pages.Length)
            display.sprite = pages[_current];

        if (contentsPanel != null)
            contentsPanel.SetActive(_current == ContentsPageIndex);
    }
}
