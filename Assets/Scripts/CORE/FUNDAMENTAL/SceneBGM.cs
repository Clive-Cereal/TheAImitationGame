using UnityEngine;
using FMODUnity;
using FMOD.Studio;

public class SceneBGM : MonoBehaviour
{
    [SerializeField] private EventReference bgmEvent;

    private EventInstance _instance;

    private void Start()
    {
        if (bgmEvent.IsNull) return;
        _instance = RuntimeManager.CreateInstance(bgmEvent);
        _instance.start();
    }

    private void OnDestroy()
    {
        _instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        _instance.release();
    }
}
