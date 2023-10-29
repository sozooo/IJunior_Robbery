using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    [SerializeField] private Transform _endPoint;
    [SerializeField] private float _speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _endPoint.position, _speed * Time.deltaTime);
    }
}
