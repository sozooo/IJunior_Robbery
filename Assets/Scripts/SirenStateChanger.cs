using System.Collections;
using UnityEngine;

public class SirenStateChanger : MonoBehaviour
{
    private AudioSource _sound;

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
        _sound.volume = 0f;
    }

    public void StartChanging(float targetVolume, float duration)
    {
        StartCoroutine(ChangeState(targetVolume, duration));
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

        yield break;

    }
}
