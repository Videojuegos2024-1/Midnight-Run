using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioSpawner : MonoBehaviour
{
    public GameObject[] stage = new GameObject[3];
    public Transform spawn;
    public Transform director;
    private int s;

    private void OnTriggerEnter(Collider other)
    {
        s = Random.Range(0, stage.Length);
        if (other.gameObject.tag == "Stage")
            Instantiate(stage[s], spawn.position, director.rotation);
    }
}
