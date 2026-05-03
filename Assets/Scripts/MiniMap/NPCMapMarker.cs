using System.Collections.Generic;
using UnityEngine;

public class NPCMapMarker : MonoBehaviour
{
    private static readonly List<NPCMapMarker> activeMarkers = new List<NPCMapMarker>();

    public static IReadOnlyList<NPCMapMarker> ActiveMarkers => activeMarkers;

    [Header("Map Display")]
    [SerializeField] private bool showOnMap = true;

    [Tooltip("Main icon used by both mini map and full map unless an override is assigned below.")]
    [SerializeField] private Sprite mapIcon;

    [Tooltip("Optional different icon for the mini map. Leave empty to use Map Icon.")]
    [SerializeField] private Sprite miniMapIconOverride;

    [Tooltip("Optional different icon for the full map. Leave empty to use Map Icon.")]
    [SerializeField] private Sprite fullMapIconOverride;

    [Header("Icon Size")]
    [SerializeField] private Vector2 miniMapIconSize = new Vector2(14f, 14f);
    [SerializeField] private Vector2 fullMapIconSize = new Vector2(24f, 24f);

    [Header("Optional Target")]
    [Tooltip("Leave empty to use this NPC transform. Assign this if the marker should follow a child object instead.")]
    [SerializeField] private Transform targetOverride;

    public bool ShowOnMap => showOnMap;
    public Transform Target => targetOverride != null ? targetOverride : transform;

    public Sprite GetIcon(bool fullMap)
    {
        if (fullMap && fullMapIconOverride != null)
            return fullMapIconOverride;

        if (!fullMap && miniMapIconOverride != null)
            return miniMapIconOverride;

        return mapIcon;
    }

    public Vector2 GetIconSize(bool fullMap)
    {
        return fullMap ? fullMapIconSize : miniMapIconSize;
    }

    public void SetShowOnMap(bool value)
    {
        showOnMap = value;
    }

    private void OnEnable()
    {
        if (!activeMarkers.Contains(this))
            activeMarkers.Add(this);
    }

    private void OnDisable()
    {
        activeMarkers.Remove(this);
    }

    private void OnDestroy()
    {
        activeMarkers.Remove(this);
    }
}
