using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPlayerPosition : MonoBehaviour
{
    public Vector3 startPosition;
    public Transform target;

    void Awake()
    {
        startPosition = target.position;
    }

    void OnTriggerEnter(Collider other)
    {
        target.position = startPosition;
    }
}
