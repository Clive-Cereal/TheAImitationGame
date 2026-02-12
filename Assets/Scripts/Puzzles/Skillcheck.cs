using UnityEngine;
using UnityEngine.Events;

public class Skillcheck : MonoBehaviour
{
    [Header("UI")]
    public RectTransform barRect;
    public RectTransform needleRect;
    public RectTransform zoneRect;

    [Header("Tuning")]
    [Range(0.05f, 0.9f)] 
    public float zoneWidthPercent = 0.2f;
    public float needleSpeed = 1.5f;
    public int requiredSuccesses = 3;

    [Header("Events")]
    public UnityEvent onSuccess;
    public UnityEvent onFail;
    public UnityEvent onPuzzleComplete;

    float t;
    int dir = 1;
    float zoneMin;
    float zoneMax;
    int streak;

    void OnEnable()
    {
        StartSkillCheck();
    }
    void OnDisable()
    {
        t = 0;
    }
    public void StartSkillCheck()
    {
        streak = 0;
        t = 0.5f;
        dir = 1;
        RandomizeZone();
        UpdateUI();
    }


    void Update()
    {
        t += dir * needleSpeed * Time.deltaTime;
        if (t >= 1f) { t = 1f; dir = -1; }
        if (t <= 0f) { t = 0f; dir = 1; }

        UpdateNeedle();

        if (Input.GetKeyDown(KeyCode.E) || TouchBegan())
        {
            Check();
        }
    }

    bool TouchBegan()
    {
        return Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began;
    }

    void Check()
    {
        bool hit = t >= zoneMin && t <= zoneMax;

        if (hit)
        {
            streak++;
            onSuccess?.Invoke();

            if (streak >= requiredSuccesses)
            {
                onPuzzleComplete?.Invoke();
                return;
            }
        }
        else
        {
            streak = 0;
            onFail?.Invoke();
        }

        RandomizeZone();
        UpdateUI();
    }

    void RandomizeZone()
    {
        float w = Mathf.Clamp01(zoneWidthPercent);
        zoneMin = Random.Range(0f, 1f - w);
        zoneMax = zoneMin + w;
    }

    void UpdateUI()
    {
        UpdateZone();
        UpdateNeedle();
    }

    void UpdateZone()
    {
        float barWidth = barRect.rect.width;

        float zoneWidth = barWidth * (zoneMax - zoneMin);
        zoneRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, zoneWidth);

        float x = Mathf.Lerp(-barWidth / 2f, barWidth / 2f, (zoneMin + zoneMax) * 0.5f);
        zoneRect.anchoredPosition = new Vector2(x, zoneRect.anchoredPosition.y);
    }

    void UpdateNeedle()
    {
        float barWidth = barRect.rect.width;
        float x = Mathf.Lerp(-barWidth / 2f, barWidth / 2f, t);
        needleRect.anchoredPosition = new Vector2(x, needleRect.anchoredPosition.y);
    }
}
