using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    private Vector2 spawnLocation;
    [SerializeField] GameObject[] Obstacles;

    [SerializeField] float minSpawnX;
    [SerializeField] float maxSpawnX;
    [SerializeField] float SpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawnLocation = this.gameObject.transform.position;
        InvokeRepeating("SpawnObstacle", 0.2f, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        if(Obstacles.Length > 0)
        {
            spawnLocation.x = Random.Range(minSpawnX, maxSpawnX);

            GameObject a = Instantiate(Obstacles[Random.Range(0, Obstacles.Length)]);

            a.transform.position = spawnLocation;
        }       
    }
}
