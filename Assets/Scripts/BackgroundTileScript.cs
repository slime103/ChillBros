using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTileScript : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = this.transform.position + Vector3.down * moveSpeed * Time.deltaTime;
        this.transform.position = newPos;
    }
}
