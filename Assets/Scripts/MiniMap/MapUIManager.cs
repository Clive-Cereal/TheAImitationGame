using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

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

    [Header("NPC Map Icons")]
    [SerializeField] private bool showNpcIconsOnMiniMap = true;
    [SerializeField] private bool showNpcIconsOnFullMap = true;

    [Tooltip("Optional fallback icon used only when an NPCMapMarker has no icon assigned.")]
    [SerializeField] private Sprite defaultNpcIcon;

    [Tooltip("Optional fallback size used only when an NPCMapMarker icon size is zero or negative.")]
    [SerializeField] private Vector2 defaultMiniNpcIconSize = new Vector2(14f, 14f);

    [Tooltip("Optional fallback size used only when an NPCMapMarker icon size is zero or negative.")]
    [SerializeField] private Vector2 defaultFullNpcIconSize = new Vector2(24f, 24f);

    [Tooltip("If true, NPCs outside the captured map area are hidden instead of being clamped to the edge.")]
    [SerializeField] private bool hideNpcIconsOutsideMap = true;

    [Header("World References")]
    [SerializeField] private Transform player;
    [SerializeField] private Camera topDownMapCamera;

    [Header("Map Capture Settings")]
    [Tooltip("Width / Height of generated map image. 2048x2048 = 1.")]
    [SerializeField] private float mapCaptureAspect = 1f;

    [Header("Manual Map Offset")]
    [Tooltip("Small normalized X offset for map alignment. 0.01 = 1% of map width.")]
    [SerializeField] private float mapOffsetX = 0f;

    [Tooltip("Small normalized Y offset for map alignment. 0.01 = 1% of map height.")]
    [SerializeField] private float mapOffsetY = 0f;

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

    private readonly Dictionary<NPCMapMarker, RectTransform> miniNpcIcons = new Dictionary<NPCMapMarker, RectTransform>();
    private readonly Dictionary<NPCMapMarker, RectTransform> fullNpcIcons = new Dictionary<NPCMapMarker, RectTransform>();
    private readonly List<NPCMapMarker> activeNpcBuffer = new List<NPCMapMarker>();
    private readonly List<NPCMapMarker> npcRemovalBuffer = new List<NPCMapMarker>();

    private IEnumerator Start()
    {
        SetFullMap(false);

        yield return null;

        Canvas.ForceUpdateCanvases();
        UpdateMiniMap();
        UpdateFullMapPlayerIcon();
        UpdateNpcMapIcons();
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
            UpdateNpcMapIcons();
            HandleFullMapZoom();
            HandleFullMapDrag();
        }
        else
        {
            UpdateMiniMap();
            UpdateNpcMapIcons();
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
            if (fullMapCoreImage != null)
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
            }

            UpdateFullMapPlayerIcon();
        }
        else
        {
            UpdateMiniMap();
        }

        UpdateNpcMapIcons();
    }

    private Vector2 GetNormalizedPlayerPositionOnMap()
    {
        if (player == null)
            return new Vector2(0.5f, 0.5f);

        if (!TryGetNormalizedPositionOnMap(player.position, out Vector2 normalized))
            return new Vector2(0.5f, 0.5f);

        return normalized;
    }

    private bool TryGetNormalizedPositionOnMap(Vector3 worldPosition, out Vector2 normalized)
    {
        normalized = new Vector2(0.5f, 0.5f);

        if (topDownMapCamera == null)
            return false;

        if (!topDownMapCamera.orthographic)
        {
            Debug.LogWarning("TopDownMapCamera must be Orthographic.");
            return false;
        }

        Vector3 cameraPosition = topDownMapCamera.transform.position;

        float halfMapHeight = topDownMapCamera.orthographicSize;
        float halfMapWidth = halfMapHeight * mapCaptureAspect;

        float minX = cameraPosition.x - halfMapWidth;
        float maxX = cameraPosition.x + halfMapWidth;
        float minZ = cameraPosition.z - halfMapHeight;
        float maxZ = cameraPosition.z + halfMapHeight;

        float normalizedX = Mathf.InverseLerp(minX, maxX, worldPosition.x);
        float normalizedY = Mathf.InverseLerp(minZ, maxZ, worldPosition.z);

        normalizedX += mapOffsetX;
        normalizedY += mapOffsetY;

        bool insideMap =
            normalizedX >= 0f && normalizedX <= 1f &&
            normalizedY >= 0f && normalizedY <= 1f;

        normalized = new Vector2(
            Mathf.Clamp01(normalizedX),
            Mathf.Clamp01(normalizedY)
        );

        return insideMap;
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

    private void UpdateNpcMapIcons()
    {
        BuildActiveNpcBuffer();

        RemoveInvalidNpcIcons(miniNpcIcons, activeNpcBuffer);
        RemoveInvalidNpcIcons(fullNpcIcons, activeNpcBuffer);

        if (!fullMapOpen && showNpcIconsOnMiniMap)
        {
            UpdateNpcIconsForMap(
                miniNpcIcons,
                miniMapCoreImage,
                false
            );
        }

        if (fullMapOpen && showNpcIconsOnFullMap)
        {
            UpdateNpcIconsForMap(
                fullNpcIcons,
                fullMapCoreImage,
                true
            );
        }
    }

    private void BuildActiveNpcBuffer()
    {
        activeNpcBuffer.Clear();

        IReadOnlyList<NPCMapMarker> markers = NPCMapMarker.ActiveMarkers;

        for (int i = 0; i < markers.Count; i++)
        {
            NPCMapMarker marker = markers[i];

            if (marker == null) continue;
            if (!marker.ShowOnMap) continue;
            if (!marker.gameObject.activeInHierarchy) continue;
            if (marker.Target == null) continue;

            activeNpcBuffer.Add(marker);
        }
    }

    private void UpdateNpcIconsForMap(
        Dictionary<NPCMapMarker, RectTransform> iconMap,
        RectTransform mapCoreImage,
        bool fullMap
    )
    {
        if (mapCoreImage == null) return;

        float mapWidth = mapCoreImage.rect.width;
        float mapHeight = mapCoreImage.rect.height;

        for (int i = 0; i < activeNpcBuffer.Count; i++)
        {
            NPCMapMarker marker = activeNpcBuffer[i];
            Sprite iconSprite = marker.GetIcon(fullMap);

            if (iconSprite == null)
                iconSprite = defaultNpcIcon;

            if (iconSprite == null)
            {
                RemoveNpcIcon(iconMap, marker);
                continue;
            }

            if (!iconMap.TryGetValue(marker, out RectTransform icon) || icon == null)
            {
                icon = CreateNpcIcon(marker, mapCoreImage, fullMap);
                iconMap[marker] = icon;
            }

            Image image = icon.GetComponent<Image>();
            if (image != null)
            {
                image.sprite = iconSprite;
                image.color = Color.white;
                image.raycastTarget = false;
                image.preserveAspect = true;
            }

            Vector2 iconSize = marker.GetIconSize(fullMap);
            if (iconSize.x <= 0f || iconSize.y <= 0f)
                iconSize = fullMap ? defaultFullNpcIconSize : defaultMiniNpcIconSize;

            icon.sizeDelta = iconSize;

            bool insideMap = TryGetNormalizedPositionOnMap(marker.Target.position, out Vector2 normalized);

            if (hideNpcIconsOutsideMap && !insideMap)
            {
                icon.gameObject.SetActive(false);
                continue;
            }

            float iconX = (normalized.x - 0.5f) * mapWidth;
            float iconY = (normalized.y - 0.5f) * mapHeight;

            icon.gameObject.SetActive(true);
            icon.anchoredPosition = new Vector2(iconX, iconY);
            icon.localRotation = Quaternion.identity;
        }
    }

    private RectTransform CreateNpcIcon(NPCMapMarker marker, RectTransform parent, bool fullMap)
    {
        GameObject iconObject = new GameObject(
            marker.name + (fullMap ? "_FullMapIcon" : "_MiniMapIcon"),
            typeof(RectTransform),
            typeof(CanvasRenderer),
            typeof(Image)
        );

        iconObject.transform.SetParent(parent, false);

        RectTransform rectTransform = iconObject.GetComponent<RectTransform>();
        rectTransform.anchorMin = new Vector2(0.5f, 0.5f);
        rectTransform.anchorMax = new Vector2(0.5f, 0.5f);
        rectTransform.pivot = new Vector2(0.5f, 0.5f);
        rectTransform.localScale = Vector3.one;
        rectTransform.localRotation = Quaternion.identity;

        Image image = iconObject.GetComponent<Image>();
        image.raycastTarget = false;
        image.preserveAspect = true;

        return rectTransform;
    }

    private void RemoveNpcIcon(Dictionary<NPCMapMarker, RectTransform> iconMap, NPCMapMarker marker)
    {
        if (iconMap.TryGetValue(marker, out RectTransform icon) && icon != null)
            Destroy(icon.gameObject);

        iconMap.Remove(marker);
    }

    private void RemoveInvalidNpcIcons(
        Dictionary<NPCMapMarker, RectTransform> iconMap,
        List<NPCMapMarker> validMarkers
    )
    {
        npcRemovalBuffer.Clear();

        foreach (KeyValuePair<NPCMapMarker, RectTransform> pair in iconMap)
        {
            if (pair.Key == null || pair.Value == null || !validMarkers.Contains(pair.Key))
                npcRemovalBuffer.Add(pair.Key);
        }

        for (int i = 0; i < npcRemovalBuffer.Count; i++)
        {
            NPCMapMarker marker = npcRemovalBuffer[i];

            if (iconMap.TryGetValue(marker, out RectTransform icon) && icon != null)
                Destroy(icon.gameObject);

            iconMap.Remove(marker);
        }
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
