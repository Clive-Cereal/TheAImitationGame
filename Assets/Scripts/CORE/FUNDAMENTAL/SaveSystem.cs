using System;
using System.IO;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public string      playerName;
    public int         days;
    public GameMode    gameMode;
    public AnyaOutcome anyaOutcome;
    public string      notepadContent;
}

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get; private set; }

    public event Action<SaveData> OnSave;
    public event Action<SaveData> OnLoad;

    private SaveData currentSaveData;
    private string savePath;
    private const string SAVE_FILENAME = "BorderlineHumanSaveData.json";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        savePath = Path.Combine(Application.persistentDataPath, SAVE_FILENAME);
    }

    public SaveData GetSaveData() => currentSaveData == null
        ? null
        : JsonUtility.FromJson<SaveData>(JsonUtility.ToJson(currentSaveData));

    public void SaveGame(SaveData data)
    {
        try
        {
            string json = JsonUtility.ToJson(data, true);
            File.WriteAllText(savePath, json);
            currentSaveData = JsonUtility.FromJson<SaveData>(json);
            OnSave?.Invoke(GetSaveData());
        }
        catch (Exception e)
        {
            Debug.LogError($"Save failed: {e.Message}");
        }
    }

    public SaveData LoadGame()
    {
        try
        {
            if (!File.Exists(savePath))
                return null;

            string json    = File.ReadAllText(savePath);
            currentSaveData = JsonUtility.FromJson<SaveData>(json);
            OnLoad?.Invoke(GetSaveData());
            return currentSaveData;
        }
        catch (Exception e)
        {
            Debug.LogError($"Load failed: {e.Message}");
            return null;
        }
    }
}
