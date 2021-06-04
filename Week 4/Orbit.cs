using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public float speed = 1.0f;
    private float angle = 0.0f;
    public float radius = 1.0f;
    private float originalY;

    //Orbits around parent
    public Transform par;

    public float low = 1.0f, high = 10.0f;
    private float delta, counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        delta = Mathf.Sin(counter) * 0.5f + 0.5f;
        counter += speed * Time.deltaTime;
        transform.position = new Vector3(radius * Mathf.Cos(angle) + par.position.x, (delta * low) + (1 - delta) * high, radius * Mathf.Sin(angle) + par.position.z);
        angle += speed * Time.deltaTime;

        transform.Rotate(0.0f, speed * Time.deltaTime, 0.0f, Space.Self);
    }
}
