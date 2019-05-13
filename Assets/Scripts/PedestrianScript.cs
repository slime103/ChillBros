using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianScript : ObstacleScript
{
    [SerializeField] Sprite[] Sprites;

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        sr.sprite = Sprites[Random.Range(0, Sprites.Length)];
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ragdoll"))
        {
            collision.gameObject.GetComponent<RagdollScript>().TakeDamage(DamageToPlayer);
            HitAudio.Play();
        }
    }
}
