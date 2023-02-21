using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreSaver : MonoBehaviour
{
    [SerializeField] TextMeshPro ScoreText;
    public float LastScore;

    ScoreSaver Instance;
    private void Awake()
    {
        if (Instance)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(gameObject);
        if (ScoreText)
        {
            
            if (ScoreText.text == string.Empty || ScoreText.text == "")
            {

            }
            else
            {
                ScoreText.text = LastScore.ToString();
            }
        }
       
    }


}
