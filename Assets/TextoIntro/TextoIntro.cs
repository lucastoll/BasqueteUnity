using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextoIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DisplayNone", 4);
    }


    public void DisplayNone()
    {
        gameObject.SetActive(false);
    }
}
