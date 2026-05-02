using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class SleepTransitionUI : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private CanvasGroup blackScreenGroup;
    [SerializeField] private TMP_Text messageText;

    [Header("Timing")]
    [SerializeField] private float fadeToBlackTime = 2f;
    [SerializeField] private float messageTime = 2f;
    [SerializeField] private float fadeBackTime = 2f;

    private Coroutine currentRoutine;

    private void Awake()
    {
        if (blackScreenGroup != null)
        {
            blackScreenGroup.alpha = 0f;
            blackScreenGroup.blocksRaycasts = false;
            blackScreenGroup.interactable = false;
        }

        if (messageText != null)
        {
            messageText.text = "";
            messageText.enabled = false;
        }
    }

    public void PlaySleepTransition(string message, Action onFullyBlack, Action onFinished)
    {
        if (currentRoutine != null)
        {
            StopCoroutine(currentRoutine);
        }

        currentRoutine = StartCoroutine(SleepRoutine(message, onFullyBlack, onFinished));
    }

    private IEnumerator SleepRoutine(string message, Action onFullyBlack, Action onFinished)
    {
        if (blackScreenGroup == null)
        {
            onFullyBlack?.Invoke();
            onFinished?.Invoke();
            yield break;
        }

        blackScreenGroup.blocksRaycasts = true;
        blackScreenGroup.interactable = true;

        if (messageText != null)
        {
            messageText.enabled = false;
            messageText.text = "";
        }

        yield return Fade(0f, 1f, fadeToBlackTime);

        onFullyBlack?.Invoke();

        if (messageText != null)
        {
            messageText.text = message;
            messageText.enabled = true;
        }

        yield return new WaitForSecondsRealtime(messageTime);

        if (messageText != null)
        {
            messageText.enabled = false;
            messageText.text = "";
        }

        yield return Fade(1f, 0f, fadeBackTime);

        blackScreenGroup.blocksRaycasts = false;
        blackScreenGroup.interactable = false;

        currentRoutine = null;
        onFinished?.Invoke();
    }

    private IEnumerator Fade(float from, float to, float duration)
    {
        if (duration <= 0f)
        {
            blackScreenGroup.alpha = to;
            yield break;
        }

        float timer = 0f;

        while (timer < duration)
        {
            timer += Time.unscaledDeltaTime;
            float t = Mathf.Clamp01(timer / duration);
            blackScreenGroup.alpha = Mathf.Lerp(from, to, t);
            yield return null;
        }

        blackScreenGroup.alpha = to;
    }
}