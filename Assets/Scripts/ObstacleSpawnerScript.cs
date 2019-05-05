using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    private Vector2 spawnLocationA;
    private Vector2 spawnLocationB;

    [SerializeField] GameObject[] Obstacles;
    [SerializeField] GameObject[] CarSpawnPositions;
    [SerializeField] GameObject[] CopCarSpawnPositions;
    [SerializeField] GameObject[] SideWalkSpawnPositions;

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
            GameObject b = null;

            if (Random.Range(0.0f, 10.0f) > 3.0f)
            {
                // Spawn normal cars at an increased rate
                a = Instantiate(Obstacles[0]);
            }
            else
            {
                a = Instantiate(Obstacles[1]);
            }

            if (a.CompareTag("Car"))
            {
                spawnLocationA = CarSpawnPositions[Random.Range(0, CarSpawnPositions.Length)].transform.position;
            }
            else if (a.CompareTag("CopCar"))
            {
                spawnLocationA = CopCarSpawnPositions[Random.Range(0, CopCarSpawnPositions.Length)].transform.position;
            }

            if (Random.Range(0.0f, 10.0f) > 2.0f)
            {
                // Spawn Pedestrian
                b = Instantiate(Obstacles[2]);
            }
            else
            {
                b = Instantiate(Obstacles[3]);
            }

            spawnLocationB = SideWalkSpawnPositions[Random.Range(0, SideWalkSpawnPositions.Length)].transform.position;

            a.transform.position = spawnLocationA;
            b.transform.position = spawnLocationB;
        }       
    }
}
