using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTilerScript : MonoBehaviour
{
    public GameObject BackgroundTile;
    public float SpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnTiles", 0.0f, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTiles()
    {
        GameObject a = null;

        a = Instantiate(BackgroundTile);
        a.transform.position = this.transform.position;
    }
}
