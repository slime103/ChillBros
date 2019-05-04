using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : ObstacleScript
{
    SpriteRenderer sr;

    [SerializeField] Sprite[] CarSprites;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        sr.sprite = CarSprites[Random.Range(0, CarSprites.Length)];
    }
}
