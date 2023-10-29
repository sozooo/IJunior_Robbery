using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VolumeScript : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _radius;
    [SerializeField] private float _recoveryRate;
    [SerializeField] private float _maxVolume;

    private float _currentModificator;
    private float _minVolume = 0f;

    private void Awake()
    {
        _currentModificator = _radius;
    }

    private void Update()
    {
        Vector2 distance = _target.transform.position - transform.position;
        _currentModificator = Mathf.MoveTowards(_currentModificator, distance.magnitude, _recoveryRate * Time.deltaTime);

        _audioSource.volume = Mathf.Lerp(_maxVolume, _minVolume, _currentModificator / _radius);
    }
}
