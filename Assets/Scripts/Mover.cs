using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
    }
}
