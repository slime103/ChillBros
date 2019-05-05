using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTileScript : MonoBehaviour
{
    SpriteRenderer sr;

    [SerializeField] Sprite[] Backgrounds;
    [SerializeField] float moveSpeed = 10.0f;
    [SerializeField] float LifeTime = 3.0f;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        sr.sprite = Backgrounds[Random.Range(0, Backgrounds.Length)];

        Destroy(this.gameObject, LifeTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPos = this.transform.position + Vector3.down * moveSpeed * Time.deltaTime;
        this.transform.position = newPos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ragdoll"))
        {
            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collision2D>().collider);
        }
    }
}
