using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 newPos;
    private int moveDirection;
    [SerializeField] float moveSpeed = 10.0f;
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

        rb.transform.position = Vector3.Lerp(rb.transform.position, newPos, 1f);
    }

    void GetMoveDirection()
    {
        if(Input.GetKey(KeyCode.D))
        {
            moveDirection = 1;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            moveDirection = -1;
        }
        else
        {
            moveDirection = 0;
        }
    }
}
