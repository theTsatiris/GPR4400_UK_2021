using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpMovement : MonoBehaviour
{
    public GameObject start;
    public GameObject finish;
    public GameObject start2;
    public GameObject finish2;

    private float delta1 = 0.0f;
    private float delta2 = 0.0f;

    private float counter = 0.0f;
    public float speed = 0.1f;

    private float origY;

    // Start is called before the first frame update
    void Start()
    {
        origY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        delta1 =0.5f* Mathf.Sin(counter) + 0.5f;
        delta2 = 0.5f * Mathf.Cos(counter) + 0.5f;

        float newX = (1 - delta1) * start.transform.position.x + delta1 * finish.transform.position.x;
            float newY = (1 - delta1) * start.transform.position.y + delta1 * finish.transform.position.y;
             newY =  newY +origY;
            float newZ = (1 - delta2) * start2.transform.position.z + delta2 * finish2.transform.position.z;
            transform.position = new Vector3(newX, newY, newZ);
            counter += speed * Time.deltaTime;
        
    }
}
