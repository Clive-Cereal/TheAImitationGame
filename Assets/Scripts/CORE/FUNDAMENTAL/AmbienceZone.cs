using UnityEngine;
using FMODUnity;
using FMOD.Studio;

[RequireComponent(typeof(SphereCollider))]
public class AmbienceZone : MonoBehaviour
{
    [SerializeField] private EventReference ambienceEvent;
    [SerializeField] private float fadeSpeed = 1.5f;

    [Header("Occlusion")]
    [SerializeField] private LayerMask occlusionLayers = ~0;
    [Tooltip(" 0 = silent when blocked, 1 = no occlusion effect.")]
    [SerializeField, Range(0f, 1f)] private float occludedVolume = 0.1f;

    private EventInstance _instance;
    private SphereCollider _zone;
    private Transform _player;
    private float _targetVolume;

    private void Start()
    {
        _zone = GetComponent<SphereCollider>();
        _zone.isTrigger = true;

        _player = GameObject.FindGameObjectWithTag("Player")?.transform;

        _instance = RuntimeManager.CreateInstance(ambienceEvent);
        _instance.start();
        _instance.setVolume(0f);
    }

    private void Update()
    {
        if (_player == null) return;

        float dist = Vector3.Distance(_player.position, transform.position);
        _targetVolume = Mathf.Clamp01(1f - dist / _zone.radius);

        if (_targetVolume > 0f)
        {
            Vector3 toZone = transform.position - _player.position;
            if (Physics.Raycast(_player.position, toZone.normalized, toZone.magnitude, occlusionLayers))
                _targetVolume *= occludedVolume;
        }

        _instance.getVolume(out float current);
        _instance.setVolume(Mathf.MoveTowards(current, _targetVolume, fadeSpeed * Time.deltaTime));
    }

    private void OnDestroy()
    {
        _instance.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        _instance.release();
    }
}
