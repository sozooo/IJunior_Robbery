using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class VolumeScript : MonoBehaviour
{
    [SerializeField] private float _maxVolume;

    private AudioSource _sound;
    private float _minVolume = 0f;
    private VolumeChanger _volumeChanger;
    //private float _recoveryRate = 0f;

    private void Start()
    {
        _sound = GetComponent<AudioSource>();
    }


    
    public void VolumeChanger(float maxDelta)
    {
        Debug.Log("MaxDelta  = " + _sound.volume);

        _sound.volume = Mathf.Lerp(_maxVolume, _minVolume, maxDelta);
        Debug.Log("Звук  = " + _sound.volume);
    }
}

[System.Serializable]
public class VolumeChanger : UnityEvent<float> { }