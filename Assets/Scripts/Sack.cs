using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Sack : MonoBehaviour
{
    [SerializeField] public GameManager gamemanager;
    [SerializeField] public int Amount;
    public abstract void MySackFanc();

    public void OnTriggerEnter(Collider other)
    {
        print("trigger");
        if (other.CompareTag("Rock"))
        {
            print("Insdie");
            MySackFanc();
        }
    }


}
