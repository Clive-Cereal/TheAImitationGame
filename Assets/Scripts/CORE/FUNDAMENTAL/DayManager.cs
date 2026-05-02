using UnityEngine;
using System;
using System.Collections;

public class DayManager : MonoBehaviour
{
    public static DayManager Instance { get; private set; }

    [Header("Scene References")]
    [SerializeField] private SubjectSpawner spawner;
    [SerializeField] private LightSwitch lightSwitch;
    [SerializeField] private MazePuzzleManager reviewPuzzle;

    [Header("Day Settings")]
    [SerializeField] private int subjectsPerDay = 5;
    [SerializeField] private int maxWarnings = 3;

    [Header("Review Gate")]
    [SerializeField] private bool requirePuzzleBeforeReview = true;

    

    public DayState CurrentDayState { get; private set; } = DayState.Idle;
    public bool CanLeaveOffice { get; private set; } = false;
    private int warnings;
    private float dayTimer;
    private int subjectsProcessed;
    private Subject currentSubject;
    private Subject puzzleSolvedForSubject;
    private bool reviewPuzzleActive;
    private PlayerController PlayerController;

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
        PlayerController = FindFirstObjectByType<PlayerController>();
        lightSwitch.SetInteractable(true);
        CanLeaveOffice = false;
        UIManager.Instance.UpdateDay(GameManager.Days);
        UIManager.Instance.UpdateWarnings(0);
        UIManager.Instance.UpdateTimer(0f);

        
    }

    private void Update()
    {
        if (CurrentDayState == DayState.Working || CurrentDayState == DayState.Reviewing)
        {
            dayTimer += Time.deltaTime;
            UIManager.Instance.UpdateTimer(dayTimer);
        }
    }

    // ── Public API ──────────────────────────────────────────────────────────
    public void StartDay()
    {
    if (CurrentDayState != DayState.Idle) return;

    CurrentDayState = DayState.Working;
    CanLeaveOffice = false;

    warnings = 0;
    subjectsProcessed = 0;
    dayTimer = 0f;
    currentSubject = null;
    puzzleSolvedForSubject = null;
    reviewPuzzleActive = false;

    if (reviewPuzzle != null)
        reviewPuzzle.ForceClose();

    lightSwitch.SetInteractable(true);

    UIManager.Instance.UpdateWarnings(0);
    UIManager.Instance.UpdateDay(GameManager.Days);

    OnDayStarted?.Invoke();
    SpawnNextSubject();
    }

    public void EndDay()
    {
    if (CurrentDayState != DayState.DayEnded) return;

    CurrentDayState = DayState.Idle;
    CanLeaveOffice = true;

    lightSwitch.SetInteractable(true);

    UIManager.Instance.UpdateDay(GameManager.Days);

    OnDayEnded?.Invoke();
    Debug.Log("Day ended. You can now leave the office.");
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

    public void OnSubjectArrived(Subject subject)
    {
        currentSubject = subject;
        puzzleSolvedForSubject = null;
        reviewPuzzleActive = false;
    }

    public void StartReview()
{
    if (currentSubject == null || CurrentDayState != DayState.Working) return;
    if (reviewPuzzleActive) return;

    bool needsPuzzle = requirePuzzleBeforeReview &&
                       reviewPuzzle != null &&
                       puzzleSolvedForSubject != currentSubject;

    if (needsPuzzle)
    {
        reviewPuzzleActive = true;

        if (UIManager.Instance != null)
        {
            UIManager.Instance.HidePanel();
        }

        if (PlayerController != null)
        {
            PlayerController.SetInputEnabled(false);
        }

        reviewPuzzle.StartPuzzle(OnReviewPuzzleSolved);
        return;
    }

    BeginReviewForCurrentSubject();
}

    public void ExitReview()
    {
        if (CurrentDayState != DayState.Reviewing) return;

        CurrentDayState = DayState.Working;
        UIManager.Instance.HidePanel();
        if (PlayerController != null) PlayerController.SetInputEnabled(true);
    }

    private void OnReviewPuzzleSolved()
    {
        reviewPuzzleActive = false;

        if (currentSubject == null || CurrentDayState != DayState.Working)
        {
            if (PlayerController != null) PlayerController.SetInputEnabled(true);
            return;
        }

        puzzleSolvedForSubject = currentSubject;
        BeginReviewForCurrentSubject();
    }

    private void BeginReviewForCurrentSubject()
    {
        if (currentSubject == null || CurrentDayState != DayState.Working) return;

        CurrentDayState = DayState.Reviewing;
        if (PlayerController != null) PlayerController.SetInputEnabled(false);
        UIManager.Instance.ShowSubject(currentSubject);
        if (InspectionToolsManager.Instance != null)
            InspectionToolsManager.Instance.PopulateTablet(currentSubject);
    }

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
            UIManager.Instance.UpdateWarnings(warnings);
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

        UIManager.Instance.HidePanel();
        if (PlayerController != null) PlayerController.SetInputEnabled(true);
        currentSubject = null;
        puzzleSolvedForSubject = null;
        reviewPuzzleActive = false;
        subjectsProcessed++;

        if (approvedAsHuman)
            spawner.SendSubjectAway();
        else
            spawner.SendSubjectBack();
        SpawnNextSubject();
    }

    private void FinishAllSubjects()
    {
        CurrentDayState = DayState.DayEnded;
        UIManager.Instance.HidePanel();
        if (reviewPuzzle != null) reviewPuzzle.ForceClose();
        if (PlayerController != null) PlayerController.SetInputEnabled(true);
        lightSwitch.SetInteractable(true);
        Debug.Log("All subjects processed. Interact with the light switch to end the day.");
    }

    public void TriggerGameOver()
    {
        CurrentDayState = DayState.Idle;
        UIManager.Instance.HidePanel();
        if (reviewPuzzle != null) reviewPuzzle.ForceClose();
        spawner.DestroyCurrentSubject();
        if (PlayerController != null) PlayerController.SetInputEnabled(true);

        currentSubject = null;
        puzzleSolvedForSubject = null;
        reviewPuzzleActive = false;

        OnGameOver?.Invoke();
        Debug.Log("GAME OVER — 3 warnings reached. You are fired.");

        CanLeaveOffice = false;
    }
}
