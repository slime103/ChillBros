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
}
