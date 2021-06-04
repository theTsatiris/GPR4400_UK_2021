using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitScript : MonoBehaviour
{
    private float delta = 0.0f;
    public float speed = 0.1f;
    private float angle = 0.0f;
    public float orbitRadius = 1.0f;
    public float rotationSpeed = 30.0f;

    public float low = 2.0f;
    public float high = 10.0f;

    private float originalY;
    private float counter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        delta = 0.5f * Mathf.Sin(counter) + 0.5f;
        float newY = (1 - delta) * low + delta * high;

        transform.position = new Vector3((orbitRadius * Mathf.Cos(angle)), newY, (orbitRadius * Mathf.Sin(angle)));
        angle += speed * Time.deltaTime; 
        counter += speed * Time.deltaTime;


        transform.Rotate(0.0f, rotationSpeed * Time.deltaTime, 0.0f, Space.Self);
    }
}
