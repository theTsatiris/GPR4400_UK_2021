using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    public int numberOfObstacles;

    private void Awake()
    {
        
    }

    void Start()
    {
        for(int i = 0; i < numberOfObstacles; i++)
        {
            Vector3 position = new Vector3(Random.Range(-4f, 4f), 0.5f, Random.Range(-477f, 477f));
            GameObject obstacle = Instantiate(obstaclePrefab[Random.Range(0,obstaclePrefab.Length)], position, Quaternion.identity);

            if (Random.Range(0, 3) == 1)
                obstacle.AddComponent(typeof(ObstacleScan));
        }
    }


}
