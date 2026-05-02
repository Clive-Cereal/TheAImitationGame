using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [HideInInspector] public static GameState currentState = GameState.Init;
    [Header("Uncheck this if you are testing from non-init scene")]
    [SerializeField] private bool initialiseOnStart = true;

    public static GameState currentGameState => currentState;
    public static string targetScene;
    public static GameState targetState;
    public static int        Days           = 1;
    public static int        MaxDays        = 20;
    public static GameMode   currentGameMode;
    public static AnyaOutcome CurrentOutcome = AnyaOutcome.None;
    public static string     NotepadContent = "";

    // Game world date: Day 1 = 01 NOV 2378, Day 20 = 20 NOV 2378
    public const int GameYear       = 2378;
    public const int GameStartMonth = 11;   // November
    public const int GameStartDay   = 1;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (SaveManager.Instance != null)
            SaveManager.Instance.OnLoad += RestoreFromSave;

        if (initialiseOnStart && currentState == GameState.Init)
            Initialise();
        else if (!initialiseOnStart)
            currentState = GameState.Playing;
    }

    private void OnDestroy()
    {
        if (SaveManager.Instance != null)
            SaveManager.Instance.OnLoad -= RestoreFromSave;
    }

    private void RestoreFromSave(SaveData data)
    {
        Days           = data.days;
        currentGameMode = data.gameMode;
        CurrentOutcome = data.anyaOutcome;
        NotepadContent = data.notepadContent ?? "";
    }

    public void SaveGame()
    {
        if (SaveManager.Instance == null) return;
        SaveManager.Instance.SaveGame(new SaveData
        {
            days           = Days,
            gameMode       = currentGameMode,
            anyaOutcome    = CurrentOutcome,
            notepadContent = NotepadContent
        });
    }

//---------------------------------------------------------------------

    void Initialise()
    {
        SceneLoader("01_Menu", GameState.Menu);
    }

    public void SceneLoader(string sceneName, GameState stateName)
    {
        targetScene = sceneName;
        targetState = stateName;
        SceneManager.LoadScene("_Loading");
    }

//-------------------FOR UI BUTTONS------------------------------------

    public void StartNewGame()
    {
        Days = 1;
        SceneLoader("02_Main", GameState.Playing);
    }

    public void ContinueGame()
    {
        SaveManager.Instance.LoadGame();
        SceneLoader("02_Main", GameState.Playing);
    }

    public void LoadMenuScene()
    {
        SceneLoader("01_Menu", GameState.Menu);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SkipToPark()
    {
        SceneLoader("03_ParkNeighbourhood", GameState.Playing);
    }

//-----------Utility----------------------------------------------------

    public void SetGameMode(string mode)
    {
        currentGameMode = (GameMode)System.Enum.Parse(typeof(GameMode), mode);
    }

    public void ConsoleMessage(string message)
    {
        Debug.Log(message);
    }
}
