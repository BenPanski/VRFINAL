using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawnRock : MonoBehaviour
{




    // Prefab of the rock game object
    public GameObject rockPrefab;
    [SerializeField] public GameObject WhereToSpawn;
    [SerializeField] public GameManager gamemanager;
    private GameObject LastRock;
    public static SimpleSpawnRock instance;

    // Size of the object pool

    // List to store the pool of rock game objects
    // Update is called once per frame
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
           
        }
        else
        {
            Destroy(this);

        }
        
    }
    private void Start()
    {
        StartGame();
    }


    public void TrySpawnRock()
    {


        if (LastRock.transform.position == WhereToSpawn.transform.position)
        {
            print("out of rocks");
        }
        else
        {
            GameObject newRock = Instantiate(rockPrefab, WhereToSpawn.transform.position, Quaternion.identity);
            newRock.transform.position = WhereToSpawn.transform.position;
            LastRock = newRock;
        }



    }

    private void StartGame()
    {
        print("start game");
        GameObject newRock = Instantiate(rockPrefab, WhereToSpawn.transform.position, Quaternion.identity);
        newRock.transform.position = WhereToSpawn.transform.position;
        LastRock = newRock;
    }
}
