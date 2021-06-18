using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScan : MonoBehaviour
{

    Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = startPos;

        v.x += 1.5f * Mathf.Sin(Time.time * 2.0f);
        transform.position = v;
    }
}
