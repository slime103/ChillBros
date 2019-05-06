using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotdogStandScript : ObstacleScript
{
    [SerializeField] float HealAmount = 10.0f;

    protected new void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ragdoll"))
        {
            collision.gameObject.GetComponent<RagdollScript>().Heal(HealAmount);
        }
    }
}
