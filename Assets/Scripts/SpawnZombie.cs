using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] GameObject _zombiePrefab;
    [SerializeField] GameObject randomPosition;
    System.Random randomSpawn = new System.Random();
    [SerializeField] int maxX;
    [SerializeField] int minX;
    [SerializeField] int maxZ;
    [SerializeField] int minZ;
    float spawnDelay;
    [SerializeField] float BaseSpawnDelay = 3;
    [SerializeField] int zombieAmount = 3;
    [SerializeField] float minSpawningIntervals;
    [SerializeField, Range(0f, 0.2f)] float spawnSpeedDecreaseRate;

    int randomX;
    int randomZ;
    Vector3 vector3;



    private void Start()
    {
        spawnDelay = BaseSpawnDelay;
        StartCoroutine(SpawnZombies());
    }

    IEnumerator SpawnZombies()
    {
        for (int i = 0; i < zombieAmount; i++)
        {
            randomX = randomSpawn.Next(minX, maxX);
            randomZ = randomSpawn.Next(minZ, maxZ);
            vector3 = new Vector3(randomX, 0, randomZ);
            randomPosition.transform.position = vector3;
         var z=   Instantiate(_zombiePrefab, vector3, Quaternion.identity);
            z.GetComponent<Zombie>().gameManager = gameManager;
            yield return new WaitForSecondsRealtime(spawnDelay);
            if (spawnDelay > minSpawningIntervals)
            {
                spawnDelay -= spawnDelay * spawnSpeedDecreaseRate;
                spawnDelay = Mathf.Clamp(spawnDelay, minSpawningIntervals, BaseSpawnDelay);

            }
        }
    }

}
