﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CopCarScript : ObstacleScript
{
    protected new void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            // End game, player caught
            SceneManager.LoadScene(2);
        }
        else if (collision.gameObject.CompareTag("Ragdoll"))
        {
            collision.gameObject.GetComponent<RagdollScript>().TakeDamage(DamageToPlayer);
            HitAudio.Play();
        }
    }
}
