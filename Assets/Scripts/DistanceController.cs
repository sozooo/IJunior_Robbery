using UnityEngine;
using UnityEngine.Events;

public class DistanceController : MonoBehaviour
{
    [SerializeField] private VolumeChanger _volumeChanger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<MoveScript>(out MoveScript moveScript))
        {
            _volumeChanger.Invoke(0.3f,1f);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<MoveScript>(out MoveScript moveScript))
        {
            _volumeChanger.Invoke(0f, 1f);
        }
    }

    [System.Serializable]
    public class VolumeChanger : UnityEvent<float, float> { }
}
