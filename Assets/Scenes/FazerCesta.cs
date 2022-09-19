using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FazerCesta : MonoBehaviour
{
    [SerializeField] private Image customImage;

    void OnTriggerEnter(Collider other)
    {
        customImage.enabled = true;
    }
}
