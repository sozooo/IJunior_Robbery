using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class VolumeScript : MonoBehaviour
{
    [SerializeField] private float _maxVolume;

    private AudioSource _sound;

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
        _sound.volume = 0f;
    }

    public void StartVolumeChange(float targetVolume, float duration)
    {
        StartCoroutine(VolumeChanger(targetVolume, duration));
    }

    private IEnumerator VolumeChanger(float targetVolume, float duration)
    {
        float currentTime = 0;
        float start = _sound.volume;

        while (currentTime < duration)
        {
            currentTime += Time.deltaTime;
            _sound.volume = Mathf.Lerp(start, targetVolume, currentTime / duration);
            Debug.Log("_sound.Volume = " + _sound.volume);

            yield return null;
        }

        yield break;

    }
}
