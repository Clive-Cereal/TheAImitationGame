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
        conversationUI.UpdateTimer(0f);
    }

    private void Update()
    {
        if (CurrentDayState == DayState.Working || CurrentDayState == DayState.Reviewing)
        {
            dayTimer += Time.deltaTime;
            conversationUI.UpdateTimer(dayTimer);
        }
    }

    // ── Public API ──────────────────────────────────────────────────────────
    public void StartDay()
    {
        if (CurrentDayState != DayState.Idle) return;

        CurrentDayState   = DayState.Working;
        warnings          = 0;
        subjectsProcessed = 0;
        dayTimer          = 0f;

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

        lightSwitch.SetInteractable(false);
        conversationUI.UpdateDay(GameManager.Days);

        OnDayEnded?.Invoke();
        Debug.Log("Day ended. Interact with the bed to start the next day.");
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

    /// <summary>
    /// Called when the subject reaches the interaction point.
    /// Registers the subject but does not start review — player must press E.
    /// </summary>
    public void OnSubjectArrived(Subject subject)
    {
        currentSubject = subject;
        // State stays Working; FPS stays enabled. Review starts on player interact.
    }

    /// <summary>
    /// Called by SubjectInteractable when the player presses E on the subject.
    /// </summary>
    public void StartReview()
    {
        if (currentSubject == null || CurrentDayState != DayState.Working) return;

        CurrentDayState = DayState.Reviewing;
        if (fpsController != null) fpsController.SetInputEnabled(false);
        conversationUI.ShowSubject(currentSubject);
        if (InspectionToolsManager.Instance != null)
            InspectionToolsManager.Instance.PopulateTablet(currentSubject);
    }

    /// <summary>
    /// Dismisses the review panel without a decision.
    /// Subject stays at the desk — player can press E again to resume.
    /// </summary>
    public void ExitReview()
    {
        if (CurrentDayState != DayState.Reviewing) return;

        CurrentDayState = DayState.Working;
        conversationUI.HidePanel();
        if (fpsController != null) fpsController.SetInputEnabled(true);
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
        spawner.SpawnSubject(OnSubjectArrived);
    }

    private void EvaluateDecision(bool approvedAsHuman)
    {
        if (currentSubject == null) return;

        bool shouldApprove = currentSubject.subjectType == SubjectType.ValidHuman;
        bool isCorrect     = approvedAsHuman ? shouldApprove : !shouldApprove;

        if (!isCorrect)
        {
            warnings++;
            conversationUI.UpdateWarnings(warnings);
            OnWarningAdded?.Invoke(warnings);
            Debug.Log($"Wrong decision! [{currentSubject.subjectType}] Warnings: {warnings}/{maxWarnings}");

            if (warnings >= maxWarnings)
            {
                TriggerGameOver();
                return;
            }
        }
        else
        {
            Debug.Log($"Correct decision. [{currentSubject.subjectType}]");
        }

        conversationUI.HidePanel();
        if (fpsController != null) fpsController.SetInputEnabled(true);
        currentSubject = null;
        subjectsProcessed++;

        spawner.SendSubjectAway();
        SpawnNextSubject();
    }

    private void FinishAllSubjects()
    {
        CurrentDayState = DayState.DayEnded;
        conversationUI.HidePanel();
        if (fpsController != null) fpsController.SetInputEnabled(true);
        lightSwitch.SetInteractable(true);
        Debug.Log("All subjects processed. Interact with the light switch to end the day.");
    }

    public void TriggerGameOver()
    {
        CurrentDayState = DayState.Idle;
        conversationUI.HidePanel();
        spawner.DestroyCurrentSubject();
        if (fpsController != null) fpsController.SetInputEnabled(true);

        OnGameOver?.Invoke();
        Debug.Log("GAME OVER — 3 warnings reached. You are fired.");
    }
}
