using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumirEnter : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Return))
        {
            gameObject.SetActive(false);
        }
    }
}
