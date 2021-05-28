using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _playerController : MonoBehaviour
{

    public GameObject start;
    public GameObject finish;

    private float delta = 0.0f;
    public float speed = 0.1f;

    private float counter = 0.0f;
    private float origY;

    // Start is called before the first frame update
    void Start()
    {
        origY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        delta = 0.5f * Mathf.Cos(counter) + 0.5f;

            float newX = (1 - delta) * start.transform.position.x + delta * finish.transform.position.x;
            float newY = (1 - delta) * start.transform.position.y + delta * finish.transform.position.y;
            newY = newY + origY;
            float newZ = (1 - delta) * start.transform.position.z + delta * finish.transform.position.z;
            transform.position = new Vector3(newX, newY, newZ);

        counter += speed * Time.deltaTime;
            
        
    }
}
