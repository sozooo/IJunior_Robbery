using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SirenStateChanger : MonoBehaviour
{
    [SerializeField] private float _maxVolume = 1f;
    [SerializeField] private float _changingDuration = 1f;

    private AudioSource _sound;
    private float _minVolume = 0f;

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
        _sound.Stop();
        _sound.volume = 0f;
    }

    public void EnableSiren()
    {
        _sound.Play();

        StartCoroutine(ChangeState(_maxVolume, _changingDuration));
    }

    public void DisableSiren()
    {
        StartCoroutine(ChangeState(_minVolume, _changingDuration));
    }

    private IEnumerator ChangeState(float targetVolume, float duration)
    {
        float currentTime = 0;
        float start = _sound.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            _sound.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);

            yield return null;
        }

        if (_sound.volume == 0)
            _sound.Stop();
    }
}
