using UnityEngine;
using TMPro;

public class EndingScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text bodyText;

    private static readonly System.Collections.Generic.Dictionary<AnyaOutcome, string> OutcomeText = new()
    {
        { AnyaOutcome.None,     "Your shift ended without incident.\nAnya Cayne never came through your checkpoint." },
        { AnyaOutcome.Helped,   "You let Anya Cayne through.\nShe disappeared into the city and was never found by the Bureau.\nSomewhere out there, she is free." },
        { AnyaOutcome.Refused,  "You turned Anya Cayne away.\nShe was apprehended at the next checkpoint.\nThe Bureau thanked you for your compliance." },
        { AnyaOutcome.SentHome, "You sent Anya Cayne home without filing a report.\nThe Bureau noticed the gap in your records.\nYour file was flagged for review." },
        { AnyaOutcome.Reported, "You reported Anya Cayne to the Bureau.\nShe was detained within the hour.\nYou received a commendation and a small bonus." },
    };

    private void Start()
    {
        if (bodyText == null) return;

        AnyaOutcome outcome = GameManager.CurrentOutcome;
        bodyText.text = OutcomeText.TryGetValue(outcome, out string text)
            ? text
            : "Your shift has ended.";
    }

    public void BackToMenu()
    {
        GameManager.Instance.LoadMenuScene();
    }

    public void PlayEndless()
    {
        GameManager.currentGameMode = GameMode.Endless;
        GameManager.Instance.SceneLoader("02_Main", GameState.Playing);
    }
}
