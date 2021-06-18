using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    public float movementSpeed = 50f;
    public float jumpForce = 3f;
    public float maxRandomCollisionForce, minRandomCollisionForce;
    public bool isGrounded;
    public bool hasWon;

    InputManager inputManager;
    Rigidbody rb;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        rb = GetComponent<Rigidbody>();
    }



    void FixedUpdate()
    {
        Movement();
        inputManager.HandleAllInputs();
    }

    void Movement()
    {
        Vector3 moveDir = new Vector3
            (inputManager.horizontalInput, 0, inputManager.verticalInput);

        rb.AddForce(moveDir * movementSpeed);
    }

    public void Jump()
    {
        if (isGrounded)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

    }

    private void OnCollisionStay(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Obstacle")
            rb.AddRelativeForce(Random.onUnitSphere * Random.Range(minRandomCollisionForce,maxRandomCollisionForce));
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EndBox")
        {
            hasWon = true;
            print("You Win!");

        }
    }

}
