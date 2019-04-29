using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : ObstacleScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // End game, player caught

        }
    }
}
