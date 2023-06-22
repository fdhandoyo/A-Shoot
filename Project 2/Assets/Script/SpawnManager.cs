using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animal;
    float spawnPosZ = 20;
    float spawnPosY = 0; 
    float spawnPosX = 5;
    public float startSpawning = 2.0f;
    public float minSpawningInterval = 1.0f;
    public float maxSpawningInterval = 1.5f;
    // public int animalIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startSpawning, Random.Range(minSpawningInterval, maxSpawningInterval));
    }

    // Update is called once per frame
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animal.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), spawnPosY, spawnPosZ);
        Instantiate(animal[animalIndex], spawnPos, animal[animalIndex].transform.rotation);
        
        
    }
}
 