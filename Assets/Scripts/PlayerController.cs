﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 newPos;
    private float moveDirection = 0;

    [SerializeField] float moveSpeed = 10.0f;
    [SerializeField] float LerpTime = 1.0f;

    private float InitialYPos;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InitialYPos = rb.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        GetMoveDirection();       
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            //Move player position respectively when left or right input is true
            newPos = new Vector2(rb.position.x + (moveDirection * moveSpeed * Time.deltaTime), InitialYPos);
        }


        MakeHorizontalLimits();

        rb.transform.position = Vector3.Lerp(rb.transform.position, newPos, 1f);       
    }

    void GetMoveDirection()
    {
        if(Input.GetKey(KeyCode.D))
        {
            moveDirection = Mathf.Lerp(moveDirection, 1, LerpTime);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            moveDirection = Mathf.Lerp(moveDirection, -1, LerpTime);
        }
        else
        {
            moveDirection = Mathf.Lerp(moveDirection, 0, LerpTime);
        }
    }

    void MakeHorizontalLimits()
    {
        Vector2 topRightCorner = new Vector2(1, 1);
        Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);
        edgeVector.x -= GetComponent<BoxCollider2D>().size.x / 2;
        newPos.x = Mathf.Clamp(newPos.x, -edgeVector.x, edgeVector.x);
    }
}
