using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionTest : MonoBehaviour
{
    public Vector3 finish;

    public float speed = 0.1f;
    float delta;

    Quaternion orig;

    // Start is called before the first frame update
    void Start()
    {
        orig = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        delta = 0.5f * Mathf.Sin(Time.deltaTime) + 0.5f;

        Vector3 direction = finish = transform.position;

        Quaternion rotation = Quaternion.LookRotation(direction);

        transform.rotation = Quaternion.Lerp(orig, rotation, delta);
    }
}
