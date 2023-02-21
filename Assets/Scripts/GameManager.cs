using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] RockSpawner rockSpawner;
    [SerializeField] int speed;
    [SerializeField] int hp;
    [SerializeField] public int rocks;



    private void Update()
    {
        CheckIfAlive();
    }
    public void AddRockAmount(int amount)
    {
        rocks += amount;
        rockSpawner.poolSize = rocks;
        Debug.Log("added" + amount + " now i have " + rocks);
    }

    public void AddSpeed(int amount) //todo, make this work
    {
        //todo
        //figure out if reducing or adding waight gain speed
        Debug.Log("added" + amount + " now i have " + speed);
    }

    public void AddHP(int amount)
    {
        hp += amount;
        Debug.Log("added" + amount + " now i have " + hp);

    }

    public void TakeDamage(int amount)
    {
        hp -= amount;
    }
    public void CheckIfAlive()
    {
        if (hp <= 0)
        {
            LoseGame();
        }
    }
    public void LoseGame()
    {
        SceneManager.LoadScene(0);
    }
  
    
}
