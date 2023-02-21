using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

enum ButtonType {Exit,Start,Somthing }

public class Button : MonoBehaviour
{
   [SerializeField] ButtonType MyType;

    private void OnTriggerEnter(Collider other)
    {

        print("in");
        if (other.gameObject.tag == "Player")
        {
            switch (MyType)
            {
                case ButtonType.Exit:
                    Application.Quit();
                    break;
                case ButtonType.Start:
                    SceneManager.LoadScene(1);
                    break;
                case ButtonType.Somthing:
                    //Do somthing
                    break;
                default:
                    break;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("collision");

    }
}
