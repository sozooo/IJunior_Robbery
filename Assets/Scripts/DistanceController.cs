using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class DistanceController : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> _entered;
    [SerializeField] private GameObject _target;
    [SerializeField] private float _radius;

    private float _distance;

    void Update()
    {
        _distance = (_target.transform.position - transform.position).magnitude;

        Debug.Log("Коэф = " + _distance / _radius);
        _entered.Invoke(_distance / _radius);
    }
}
