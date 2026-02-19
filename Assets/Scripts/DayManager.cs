using UnityEngine;
using System;
using System.Collections;

public class DayManager : MonoBehaviour
{
    public static DayManager Instance { get; private set; }

    [Header("Scene References")]
    [SerializeField] private SubjectSpawner spawner;
    [SerializeField] private ConversationUI conversationUI;
    [SerializeField] private LightSwitch lightSwitch;

    [Header("Day Settings")]
    [SerializeField] private float dayDuration = 300f;
    [SerializeField] private int subjectsPerDay = 5;
    [SerializeField] private int maxWarnings = 3;

    public DayState CurrentDayState { get; private set; } = DayState.Idle;

    private int warnings;
    private float dayTimer;
    private int subjectsProcessed;
    private Subject currentSubject;
    private FpsController fpsController;

    public event Action OnDayStarted;
    public event Action OnDayEnded;
    public event Action<int> OnWarningAdded;
    public event Action OnGameOver;

    private void Awake()
    {
        if (Instance != null && Instance != this) { Destroy(gameObject); return; }
        Instance = this;
    }

    private void Start()
    {
        fpsController = FindFirstObjectByType<FpsController>();
        lightSwitch.SetInteractable(true);
        conversationUI.UpdateDay(GameManager.Days);
        conversationUI.UpdateWarnings(0);
        conversationUI.UpdateTimer(dayDuration);
    }

    private void Update()
    {
        if (CurrentDayState == DayState.Working || CurrentDayState == DayState.Reviewing)
        {
            dayTimer -= Time.deltaTime;
            conversationUI.UpdateTimer(dayTimer);

            if (dayTimer <= 0f)
            {
                dayTimer = 0f;
                HandleTimerExpired();
            }
        }
    }

    // ── Public API ──────────────────────────────────────────────────────────
    public void StartDay()
    {
        if (CurrentDayState != DayState.Idle) return;

        CurrentDayState   = DayState.Working;
        warnings          = 0;
        subjectsProcessed = 0;
        dayTimer          = dayDuration;

        lightSwitch.SetInteractable(false);
        conversationUI.UpdateWarnings(0);
        conversationUI.UpdateDay(GameManager.Days);

        OnDayStarted?.Invoke();
        SpawnNextSubject();
    }

    public void EndDay()
    {
        if (CurrentDayState != DayState.DayEnded) return;

        GameManager.Days++;
        CurrentDayState = DayState.Idle;

        lightSwitch.SetInteractable(true);
        conversationUI.UpdateDay(GameManager.Days);

        OnDayEnded?.Invoke();
        Debug.Log($"Day ended. Total days completed: {GameManager.Days}");
    }

    public void OnApprove()
    {
        if (CurrentDayState != DayState.Reviewing) return;
        EvaluateDecision(approvedAsHuman: true);
    }

    public void OnReject()
    {
        if (CurrentDayState != DayState.Reviewing) return;
        EvaluateDecision(approvedAsHuman: false);
    }

    // ── Private Logic ────────────────────────────────────────────────────────
    private void SpawnNextSubject()
    {
        if (subjectsProcessed >= subjectsPerDay)
        {
            FinishAllSubjects();
            return;
        }

        CurrentDayState = DayState.Working;
        StartCoroutine(SpawnWithDelay(0.5f));
    }

    private IEnumerator SpawnWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        currentSubject = spawner.SpawnSubject();

        if (currentSubject == null)
        {
            Debug.LogWarning("DayManager: SpawnSubject returned null.");
            subjectsProcessed++;
            SpawnNextSubject();
            yield break;
        }

        CurrentDayState = DayState.Reviewing;
        fpsController?.SetInputEnabled(false);
        conversationUI.ShowSubject(currentSubject);
    }

    private void EvaluateDecision(bool approvedAsHuman)
    {
        if (currentSubject == null) return;

        bool isCorrect = approvedAsHuman ? !currentSubject.isRobot : currentSubject.isRobot;

        if (!isCorrect)
        {
            warnings++;
            conversationUI.UpdateWarnings(warnings);
            OnWarningAdded?.Invoke(warnings);
            Debug.Log($"Wrong decision! Warnings: {warnings}/{maxWarnings}");

            if (warnings >= maxWarnings)
            {
                TriggerGameOver();
                return;
            }
        }
        else
        {
            Debug.Log("Correct decision.");
        }

        conversationUI.HidePanel();
        spawner.DestroyCurrentSubject();
        currentSubject = null;
        subjectsProcessed++;

        fpsController?.SetInputEnabled(true);
        SpawnNextSubject();
    }

    private void FinishAllSubjects()
    {
        CurrentDayState = DayState.DayEnded;
        conversationUI.HidePanel();
        fpsController?.SetInputEnabled(true);
        lightSwitch.SetInteractable(true);
        Debug.Log("All subjects processed. Interact with the light switch to end the day.");
    }

    private void HandleTimerExpired()
    {
        if (CurrentDayState == DayState.Reviewing && currentSubject != null)
        {
            Debug.Log("Time expired — auto-rejecting.");
            EvaluateDecision(approvedAsHuman: false);
            return;
        }

        FinishAllSubjects();
    }

    public void TriggerGameOver()
    {
        CurrentDayState = DayState.Idle;
        conversationUI.HidePanel();
        spawner.DestroyCurrentSubject();
        fpsController?.SetInputEnabled(true);

        OnGameOver?.Invoke();
        Debug.Log("GAME OVER — 3 warnings reached. You are fired.");
    }
}
