using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy; 
    public Transform[] spawnPoints;
    public float spawnTime = 1.5f;
    public float spawnRate = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy",spawnTime,spawnRate);
    }

    void SpawnEnemy()
    {
        // Choose a random spawn point
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform chosenSpawnPoint = spawnPoints[randomIndex];

        // Instantiate the object at the chosen spawn point
        Instantiate(enemy, chosenSpawnPoint.position, Quaternion.identity);
    }
}
