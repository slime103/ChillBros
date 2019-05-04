﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    private Vector2 spawnLocation;
    [SerializeField] GameObject[] Obstacles;
    [SerializeField] GameObject[] CarSpawnPositions;
    [SerializeField] GameObject[] CopCarSpawnPositions;
    
    [SerializeField] float minSpawnX;
    [SerializeField] float maxSpawnX;
    [SerializeField] float SpawnInterval;

    // Start is called before the first frame update
    void Start()
    {
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
            GameObject a = null;

            if (Random.Range(0.0f, 10.0f) > 3.0f)
            {
                // Spawn normal cars at an increased rate
                a = Instantiate(Obstacles[0]);
            }
            else
            {
                a = Instantiate(Obstacles[1]);
            }

            if(a.CompareTag("Car"))
            {
                spawnLocation = CarSpawnPositions[Random.Range(0, CarSpawnPositions.Length)].transform.position;
            }
            else if(a.CompareTag("CopCar"))
            {
                spawnLocation = CopCarSpawnPositions[Random.Range(0, CopCarSpawnPositions.Length)].transform.position;
            }

            a.transform.position = spawnLocation;
        }       
    }
}
