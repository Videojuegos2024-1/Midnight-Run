using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioSpawner : MonoBehaviour
{
    public GameObject stage;
    public Transform spawn;
    public Transform director;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Stage")
            Instantiate(stage, spawn.position, director.rotation);
    }
}
