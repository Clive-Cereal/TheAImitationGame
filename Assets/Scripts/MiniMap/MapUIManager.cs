using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class MapUIManager : MonoBehaviour
{
    [Header("UI Roots")]
    [SerializeField] private GameObject fullMapPanel;
    [SerializeField] private GameObject miniMapRoot;

    [Header("Mini Map UI")]
    [SerializeField] private RectTransform miniMapCoreImage;
    [SerializeField] private RectTransform miniPlayerIcon;

    [Header("Full Map UI")]
    [SerializeField] private RectTransform fullMapCoreImage;
    [SerializeField] private RectTransform fullPlayerIcon;

    [Header("World References")]
    [SerializeField] private Transform player;
    [SerializeField] private Camera topDownMapCamera;

    [Header("Map Capture Settings")]
    [Tooltip("Width / Height of generated map image. 2048x2048 = 1.")]
    [SerializeField] private float mapCaptureAspect = 1f;

    [Header("Full Map Zoom / Drag")]
    [SerializeField] private float minFullMapZoom = 0.6f;
    [SerializeField] private float maxFullMapZoom = 3f;
    [SerializeField] private float zoomSpeed = 0.15f;
    [SerializeField] private bool allowDragFullMap = true;

    [Header("Options")]
    [SerializeField] private bool pauseGameWhenMapOpen = false;
    [SerializeField] private bool rotatePlayerIcon = true;
    [SerializeField] private float playerIconRotationOffset = 0f;

    private bool fullMapOpen = false;
    private float currentFullMapZoom = 1f;
    private Vector2 lastMousePosition;
    private bool draggingFullMap = false;

    private IEnumerator Start()
    {
        SetFullMap(false);

        yield return null;

        Canvas.ForceUpdateCanvases();
        UpdateMiniMap();
        UpdateFullMapPlayerIcon();
    }

    private void Update()
    {
        if (Keyboard.current != null && Keyboard.current.mKey.wasPressedThisFrame)
        {
            SetFullMap(!fullMapOpen);
        }

        if (fullMapOpen && Keyboard.current != null && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            SetFullMap(false);
        }

        if (fullMapOpen)
        {
            UpdateFullMapPlayerIcon();
            HandleFullMapZoom();
            HandleFullMapDrag();
        }
        else
        {
            UpdateMiniMap();
        }
    }

    public void CloseFullMap()
    {
        SetFullMap(false);
    }

    private void SetFullMap(bool open)
    {
        fullMapOpen = open;

        if (fullMapPanel != null)
            fullMapPanel.SetActive(open);

        if (miniMapRoot != null)
            miniMapRoot.SetActive(!open);

        if (pauseGameWhenMapOpen)
            Time.timeScale = open ? 0f : 1f;

        Cursor.visible = open;
        Cursor.lockState = open ? CursorLockMode.None : CursorLockMode.Locked;

        draggingFullMap = false;

        Canvas.ForceUpdateCanvases();

        if (open)
        {
            currentFullMapZoom = Mathf.Clamp(
                fullMapCoreImage.localScale.x,
                minFullMapZoom,
                maxFullMapZoom
            );

            fullMapCoreImage.localScale = new Vector3(
                currentFullMapZoom,
                currentFullMapZoom,
                1f
            );

            UpdateFullMapPlayerIcon();
        }
        else
        {
            UpdateMiniMap();
        }
    }

    private Vector2 GetNormalizedPlayerPositionOnMap()
    {
        if (player == null || topDownMapCamera == null)
            return new Vector2(0.5f, 0.5f);

        if (!topDownMapCamera.orthographic)
        {
            Debug.LogWarning("TopDownMapCamera must be Orthographic.");
            return new Vector2(0.5f, 0.5f);
        }

        Vector3 cameraPosition = topDownMapCamera.transform.position;
        Vector3 playerPosition = player.position;

        float halfMapHeight = topDownMapCamera.orthographicSize;
        float halfMapWidth = halfMapHeight * mapCaptureAspect;

        float minX = cameraPosition.x - halfMapWidth;
        float maxX = cameraPosition.x + halfMapWidth;
        float minZ = cameraPosition.z - halfMapHeight;
        float maxZ = cameraPosition.z + halfMapHeight;

        float normalizedX = Mathf.InverseLerp(minX, maxX, playerPosition.x);
        float normalizedY = Mathf.InverseLerp(minZ, maxZ, playerPosition.z);

        normalizedX = Mathf.Clamp01(normalizedX);
        normalizedY = Mathf.Clamp01(normalizedY);

        return new Vector2(normalizedX, normalizedY);
    }

    private void UpdateMiniMap()
    {
        if (miniMapCoreImage == null || miniPlayerIcon == null) return;

        Vector2 normalized = GetNormalizedPlayerPositionOnMap();

        float mapWidth = miniMapCoreImage.rect.width;
        float mapHeight = miniMapCoreImage.rect.height;

        float mapX = (normalized.x - 0.5f) * mapWidth;
        float mapY = (normalized.y - 0.5f) * mapHeight;

        miniMapCoreImage.anchoredPosition = new Vector2(-mapX, -mapY);
        miniPlayerIcon.anchoredPosition = Vector2.zero;

        RotateIcon(miniPlayerIcon);
    }

    private void UpdateFullMapPlayerIcon()
    {
        if (fullMapCoreImage == null || fullPlayerIcon == null) return;

        Vector2 normalized = GetNormalizedPlayerPositionOnMap();

        float mapWidth = fullMapCoreImage.rect.width;
        float mapHeight = fullMapCoreImage.rect.height;

        float iconX = (normalized.x - 0.5f) * mapWidth;
        float iconY = (normalized.y - 0.5f) * mapHeight;

        fullPlayerIcon.anchoredPosition = new Vector2(iconX, iconY);

        RotateIcon(fullPlayerIcon);
    }

    private void RotateIcon(RectTransform icon)
    {
        if (!rotatePlayerIcon || icon == null || player == null) return;

        icon.localEulerAngles = new Vector3(
            0f,
            0f,
            -player.eulerAngles.y + playerIconRotationOffset
        );
    }

    private void HandleFullMapZoom()
    {
    if (fullMapCoreImage == null || Mouse.current == null) return;

    float scrollY = Mouse.current.scroll.ReadValue().y;

    if (Mathf.Abs(scrollY) < 0.01f) return;

    float zoomDirection = scrollY > 0 ? 1f : -1f;

    currentFullMapZoom += zoomDirection * zoomSpeed;
    currentFullMapZoom = Mathf.Clamp(currentFullMapZoom, minFullMapZoom, maxFullMapZoom);

    fullMapCoreImage.localScale = new Vector3(
        currentFullMapZoom,
        currentFullMapZoom,
        1f
    );
    }

    private void HandleFullMapDrag()
    {
        if (!allowDragFullMap || fullMapCoreImage == null || Mouse.current == null) return;

        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            draggingFullMap = true;
            lastMousePosition = Mouse.current.position.ReadValue();
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            draggingFullMap = false;
        }

        if (!draggingFullMap) return;

        Vector2 currentMousePosition = Mouse.current.position.ReadValue();
        Vector2 delta = currentMousePosition - lastMousePosition;

        fullMapCoreImage.anchoredPosition += delta;
        lastMousePosition = currentMousePosition;
    }
}