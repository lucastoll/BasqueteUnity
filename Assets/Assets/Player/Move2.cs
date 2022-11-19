using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move2 : MonoBehaviour
{
	public Button upBtn;
	public Button downBtn;
	public Button leftBtn;
	public Button rightBtn;
	public Button jumpBtn;

	public float jumpForce = 3.0f;
	public float mass = 3.0f;
    public float _velocidade = 20.0f;
	private Rigidbody rigidbody;
	public bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
		//Listenner de botões
		upBtn.onClick.AddListener(Forward);
		downBtn.onClick.AddListener(Back);
		leftBtn.onClick.AddListener(Left);
		rightBtn.onClick.AddListener(Right);
		jumpBtn.onClick.AddListener(Jump);

        //Assim que o script  é executado, obtemos o componente Rigidbody e atribuimos a nossa variável
		rigidbody = GetComponent<Rigidbody>();
		//Definimos o valor da massa via script
		rigidbody.mass = mass;
    }

	public void Forward ()
	{
		rigidbody.isKinematic = false;
		rigidbody.AddForce(new Vector3(0, 0f, 1) * _velocidade);
	}
	public void Back()
	{
		rigidbody.isKinematic = false;
		rigidbody.AddForce(new Vector3(0, 0f, -1) * _velocidade);
	}
	public void Left()
	{
		rigidbody.isKinematic = false;
		rigidbody.AddForce(new Vector3(-1, 0f, 0) * _velocidade);
	}
	public void Right()
	{
		rigidbody.isKinematic = false;
		rigidbody.AddForce(new Vector3(1, 0f, 0) * _velocidade);
	}
	public void Jump()
	{
		rigidbody.isKinematic = false;
		if (canJump == true)
		{
			rigidbody.AddForce(
			Vector3.up * jumpForce, //Para fazer o personagem pular, então multiplicamos (0, 1, 0) pelo valor do pulo
			ForceMode.Impulse // Ajustamos a força para o tipo Impulse
			);
			canJump = false;
			Invoke("SetCanJump", 2);
		}
	}

	public void SetCanJump()
    {
		canJump = true;
	}
}
