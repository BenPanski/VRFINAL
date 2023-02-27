using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSpawnRock : MonoBehaviour
{




    // Prefab of the rock game object
    public GameObject rockPrefab;
    [SerializeField] public GameObject WhereToSpawn;
    [SerializeField] public GameManager gamemanager;
    [SerializeField] public List<GameObject>  rocks;
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
        int x = 0;
        foreach (var item in rocks)
        {
            if (item.activeSelf)
            {
            x++;
            }
        }
        if (x>3)
        {
            return;
        }
       

        if (LastRock.transform.position == WhereToSpawn.transform.position)
        {
            print("out of rocks");
            
        }
        else
        {
           
            if (gamemanager.rocks != 0)
            {
               
                gamemanager.rocks--;
                GameObject newRock = Instantiate(rockPrefab, WhereToSpawn.transform.position, Quaternion.identity);
                rocks.Add(newRock);
                newRock.transform.position = WhereToSpawn.transform.position;
                LastRock = newRock;
            }
            else
            {
                print("you have no balls sir!");
            }


        }

        gamemanager.UpdateUI();

    }

    private void StartGame()
    {
        print("start game");
        GameObject newRock = Instantiate(rockPrefab, WhereToSpawn.transform.position, Quaternion.identity);
        newRock.transform.position = WhereToSpawn.transform.position;
        LastRock = newRock;
    }
}
