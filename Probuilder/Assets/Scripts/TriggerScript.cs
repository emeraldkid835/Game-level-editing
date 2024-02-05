using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject _Object1;
    [SerializeField]
    private Vector3 _Object1MovePosition;
    [SerializeField]
    private GameObject _Object2;
    [SerializeField]
    private Vector3 _Object2MovePosition;
    void OnTriggerEnter(Collider other)
    {
        _Object1.transform.position = _Object1MovePosition;
        _Object2.transform.position = _Object2MovePosition;
    }
}
