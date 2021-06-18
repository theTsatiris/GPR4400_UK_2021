using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitTest : MonoBehaviour
{

    public float speed = 3f;
    public float radius = 1f;
    public float rotationSpeed = 1f;
    
    public Transform orbitObj;

    private float angle;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Cos(angle) * radius,0, Mathf.Sin(angle) * radius);
        angle += speed * Time.deltaTime;

        transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f, Space.Self);
    }
}
