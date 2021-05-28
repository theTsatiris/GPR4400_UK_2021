using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMove : MonoBehaviour
{
    public GameObject start;
    public GameObject end;

    private float delta = 0.0f;
    public float speed = 0.1f;
    private float originalY;
    private float counter = 0.0f;

    private float newX, newY, newZ;

    // Start is called before the first frame update
    void Start()
    {
        originalY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        delta = Mathf.Sin(counter) * 0.5f + 0.5f;
        newX = start.transform.position.x * (1 - delta) + end.transform.position.x * delta;
        newZ = start.transform.position.z * (1 - delta) + end.transform.position.z * delta;
        newY = start.transform.position.y * (1 - delta) + end.transform.position.y * delta + originalY;
        transform.position = new Vector3(newX, newY, newZ);
        counter += speed * Time.deltaTime;
    }
}
