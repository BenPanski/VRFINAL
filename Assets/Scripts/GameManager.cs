using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] RockSpawner rockSpawner;
    [SerializeField] int speed;
    [SerializeField] int hp;
    [SerializeField] public int rocks;
    [SerializeField] TextMeshPro Stuff;
    [SerializeField] TextMeshPro Timer;
    [SerializeField] ScoreSaver scoreSaver;
    float time;



    private void Update()
    {
        time += Time.deltaTime;
        UpdateUI();
    }
    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        Stuff.text = "HP: " + hp + " Rocks: " + rocks;
        Timer.text = time.ToString("F2");
        scoreSaver.LastScore = time;
    }

    public void AddRockAmount(int amount)
    {
        rocks += amount;
        Debug.Log("added" + amount + " now i have " + rocks);
        UpdateUI();
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
        UpdateUI();
    }

    public void TakeDamage(int amount)
    {
        hp -= amount;
        UpdateUI();

        CheckIfAlive();
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
