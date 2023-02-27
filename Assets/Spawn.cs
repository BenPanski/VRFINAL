using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform SpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = SpawnPoint.position;
        gameObject.transform.rotation = SpawnPoint.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
