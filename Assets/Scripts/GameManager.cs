using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class GameManager : MonoBehaviour, ISaveable
{
    public static GameManager Instance {get; private set;}
    [HideInInspector] public static GameState currentState = GameState.Init;
    public static GameState currentGameState => currentState;
    public static string targetScene;
    public static GameState targetState;

    public static int Days = 0;
    public static int MaxDays;
    public static GameMode currentGameMode;


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

    void Update()
    {
        Initialise();
        //Pause();
    }

//---------------------------------------------------------------------

    void Initialise()
    {
        if(currentState == GameState.Init)
        {
            SceneLoader("01_Menu", GameState.Menu);
        }
    }

    public void SceneLoader(string sceneName, GameState stateName) //To use this : eg. GameManager.Instance.SceneLoader("desiredscenename", GameState.desiredstate);
    {
        targetScene = sceneName;
        targetState = stateName;

        SceneManager.LoadScene("_Loading");
    }
//-------------------FOR UI BUTTONS------------------------------------

    public void StartNewGame()
    {
        SceneLoader("01_Main", GameState.Playing);
    }

    public void ContinueGame()
    {
        SaveManager.Instance.LoadGame();
        SceneLoader("01_Main", GameState.Playing);
    }

//---------------------------------------------------------------------
    public void ExitGame()
    {
        Application.Quit();
    }

//---------------------------------------------------------------------

    public void SetGameMode(string mode)
    {
        currentGameMode = (GameMode)System.Enum.Parse(typeof(GameMode), mode);
        Debug.Log("Game mode set to: " + currentGameMode);
    }

    public void OnSave(SaveData data)
    {
        data.days = Days;
        data.gameMode = currentGameMode;
    }

    public void OnLoad(SaveData data)
    {
        Days = data.days;
        currentGameMode = data.gameMode;
    }
}
