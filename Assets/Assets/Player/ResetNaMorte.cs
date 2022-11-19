using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetNaMorte : MonoBehaviour
{
    public float threshold = -10f;
    public Transform target;
    public Vector3 startPosition;
    public Button resetButton;


    void Awake()
    {
        startPosition = new Vector3(4f, 0.05f, 0f);
        resetButton.onClick.AddListener(Reset);
    }

    void Update()
    {
     if(transform.position.y < threshold || Input.GetKeyDown("r"))
        {
            Reset();
        }
    }

    void Reset()
    {
        target.position = startPosition;
    }
}
