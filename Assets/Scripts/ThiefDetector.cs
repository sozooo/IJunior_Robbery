using UnityEngine;
using UnityEngine.Events;

public class ThiefDetector : MonoBehaviour
{
    [SerializeField] private VolumeChanger _volumeChanger;
    [SerializeField] private float _maxVolume;

    private float _minVolume = 0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Mover>(out Mover moveScript))
        {
            _volumeChanger.Invoke(_maxVolume, 1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Mover>(out Mover moveScript))
        {
            _volumeChanger.Invoke(_minVolume, 1f);
        }
    }

    [System.Serializable]
    public class VolumeChanger : UnityEvent<float, float> { }
}
