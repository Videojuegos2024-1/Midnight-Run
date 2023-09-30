using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public GameObject enemy;
    public GameObject spawnLocation;
    int s;
    public int spawnChance = 0;

    void Start()
    {
        s = Random.Range(0, 100);
        if(s >= (100-spawnChance)){
            Instantiate(enemy, spawnLocation.transform.position, spawnLocation.transform.rotation);
        }
    }
}
