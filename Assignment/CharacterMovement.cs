using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rb;
    private Transform player;
    public float speed = 5.0f;
    public float rotationSpeed = 5.0f;
    private Camera camera;

    private Vector3 currentRotation;
    private Vector3 cameraOffset;

    // Start is called before the first frame update
    void Start()
    {
        player = transform.Find("Player");
        rb = player.gameObject.GetComponent<Rigidbody>();
        camera = transform.Find("Main Camera").GetComponent<Camera>();
        cameraOffset = camera.transform.position - player.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Cursor.lockState = CursorLockMode.Confined;

        //Character Movement
        Vector3 move = player.transform.TransformDirection(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (Input.GetButton("Lift"))
        {
            move.y += 1;
        }
        if (Input.GetButton("Drop"))
        {
            move.y -= 1;
        }
        //rb.MovePosition(player.position + move * Time.deltaTime * speed);
        rb.AddForce(move * speed);

        //Camera Placement
        camera.transform.position = player.position + cameraOffset;

        //Character Rotation
        currentRotation.x += Input.GetAxis("Mouse X") * rotationSpeed;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y -= Input.GetAxis("Mouse Y") * rotationSpeed;
        currentRotation.y = Mathf.Clamp(currentRotation.y, -90, 90);
        rb.MoveRotation(Quaternion.Euler(0, currentRotation.x, 0));

        //Camera Rotation
        camera.transform.rotation = rb.rotation;
        camera.transform.Rotate(currentRotation.y, 0, 0);
    }
}
