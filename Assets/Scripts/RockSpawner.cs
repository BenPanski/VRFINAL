using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSpawner : MonoBehaviour
{
    // Prefab of the rock game object
    public GameObject rockPrefab;
    [SerializeField] public GameObject WhereToSpawn;

    // Size of the object pool
    public int poolSize = 10;

    // List to store the pool of rock game objects
    private List<GameObject> rocks;

 
    void Start()
    {



        // Create the object pool
        rocks = new List<GameObject>();
        for (int i = 0; i < poolSize; i++)
        {

            GameObject rock = Instantiate(rockPrefab, WhereToSpawn.transform.position, Quaternion.identity);
            rock.SetActive(false);
            rocks.Add(rock);
        }
        GetRock().SetActive(true);

    }

    // Function to retrieve a rock from the pool
    public GameObject GetRock()
    {
        // Search for an inactive rock in the pool
        foreach (GameObject rock in rocks)
        {
            if (!rock.activeInHierarchy)
            {
                rock.transform.position = WhereToSpawn.transform.position;
                return rock;
            }
        }

        // If no inactive rocks are found, create a new one and add it to the pool
        GameObject newRock = Instantiate(rockPrefab, WhereToSpawn.transform.position, Quaternion.identity);
        rocks.Add(newRock);
        return newRock;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GetRock().SetActive(true);
        }
    }
}