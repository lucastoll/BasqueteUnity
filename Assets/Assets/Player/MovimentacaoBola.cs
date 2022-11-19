using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentacaoBola : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;

    private float xInput;
    private float zInput;

    private bool canJump = true;

void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rb.isKinematic = false;
            canJump = false;
            rb.AddForce(Vector3.up * 400);
            Invoke("JumpPermission", 4);
        }
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void ProcessInputs()
    {
        xInput = Input.GetAxis("Horizontal");
        Debug.Log(xInput);
        zInput = Input.GetAxis("Vertical");
    }

    private void Move()
    {
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }

    public void JumpPermission()
    {
        canJump = true;
    }
}
