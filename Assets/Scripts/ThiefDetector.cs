using UnityEngine;

[RequireComponent(typeof(SirenStateChanger))]
public class ThiefDetector : MonoBehaviour
{
    private SirenStateChanger _siren;

    private void Awake()
    {
        _siren = GetComponent<SirenStateChanger>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Mover>(out Mover moveScript))
        {
            _siren.EnableSiren();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Mover>(out Mover moveScript))
        {
            _siren.DisableSiren();
        }
    }
}
