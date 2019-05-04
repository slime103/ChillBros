﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 10.0f;
    [SerializeField] float DamageToPlayer = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }

        Vector2 newPos = rb.position + Vector2.down * moveSpeed * Time.deltaTime;
        rb.MovePosition(newPos);
    }

    protected void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Dummy"))
        {
            collision.gameObject.GetComponent<RagdollScript>().TakeDamage(DamageToPlayer);
        }
    }
}
