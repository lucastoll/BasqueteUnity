using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FazerCesta : MonoBehaviour
{
    [SerializeField] private Image customImage;
    public Text textoScore;
    public Button resetButton;
    public float threshold = -30f;

    private int pontuacao = 1000;

    void Start()
    {
        diminuiPontuacao();
        textoScore.gameObject.SetActive(false);
        resetButton.onClick.AddListener(ResetPontuacao);
    }

    void Update()
    {
        if (transform.position.y < threshold || Input.GetKeyDown("r"))
        {
            ResetPontuacao();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        customImage.enabled = true;
        textoScore.text = ("Score: " + pontuacao);
        textoScore.gameObject.SetActive(true);
    }

    void diminuiPontuacao()
    {
        pontuacao--;
        Invoke("diminuiPontuacao", 1);
    }

    void ResetPontuacao()
    {
        pontuacao = 1000;
    }
}
