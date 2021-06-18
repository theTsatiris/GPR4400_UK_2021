using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseCondition : MonoBehaviour
{
    Transform player;
    SphereController sphereController;
    public Animator UIController;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        sphereController = player.GetComponent<SphereController>();
    }

    private void Update()
    {
        if (player.transform.position.y < -0.5f)
            Lose();
        else if (sphereController.hasWon)
            Win();

    }

    void Win()
    {
        UIController.SetInteger("GameState", 1);

    }

    void Lose()
    {
        UIController.SetInteger("GameState", 2);

    }

    
}
