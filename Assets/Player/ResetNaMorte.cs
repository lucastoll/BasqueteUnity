using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetNaMorte : MonoBehaviour
{
    public float threshold = -10f;
    public Transform target;
    public Vector3 startPosition;
    [SerializeField] private Image customImage;

    void Awake()
    {
        startPosition = target.position;
    }

    void Update()
    {
     if(transform.position.y < threshold || Input.GetKeyDown("r"))
        {
            target.position = startPosition;
            customImage.enabled = false;
        }
    }
}
