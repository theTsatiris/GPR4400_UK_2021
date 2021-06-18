using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;
    public float speed = 10.0f;

    private Vector3 direction = new Vector3(0.0f, 0.0f, 0.0f);

    public float jumpMultiplier = 2f;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0.0f, 0.0f, speed);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0.0f, 0.0f, -speed);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed, 0.0f, 0.0f);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed, 0.0f, 0.0f);
        }
        if (Input.GetKey("space") && checkGround())
        {
            rb.AddForce(0.0f, jumpMultiplier, 0.0f, ForceMode.Impulse);
        }
    }

    bool checkGround()
    {
        float dist = GetComponent<Collider>().bounds.extents.y;
        return Physics.Raycast(transform.position, Vector3.down, dist + 0.1f);
    }
}
