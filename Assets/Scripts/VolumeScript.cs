using UnityEngine;

public class VolumeScript : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private float _radius;
    [SerializeField] private float _maxVolume;

    private float _minVolume = 0f;

    private void Update()
    {
        Vector2 distance = _target.transform.position - transform.position;

        _audioSource.volume = Mathf.Lerp(_maxVolume, _minVolume, distance.magnitude / _radius);
    }
}
