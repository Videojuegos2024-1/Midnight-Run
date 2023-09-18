using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    //public GameObject[] spawners = new GameObject[5];
    public GameObject[] obstacles = new GameObject[5];
    int p, s;

    // Start is called before the first frame update
    void Start()
    {
        p = Random.Range(0,100);
        s = Random.Range(0,4);
        if(p > 25){
            Instantiate(obstacles[s], this.transform.position, this.transform.rotation);
        }
    }

}
