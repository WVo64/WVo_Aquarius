using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 2.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
