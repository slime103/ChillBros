﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopCarScript : ObstacleScript
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            // End game, player caught

        }
    }
}
