using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetNaMorte : MonoBehaviour
{
    public float threshold = -30f;
    public Transform target;
    public Vector3 startPosition;
    public Button resetButton;
    public GameObject pontoDeReset;


    void Awake()
    {
        startPosition = new Vector3(51.78f, -19.344f, -21.442f);
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
        target.position = pontoDeReset.transform.position;
    }
}
