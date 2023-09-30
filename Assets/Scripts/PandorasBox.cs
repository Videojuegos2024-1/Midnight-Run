using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PandorasBox : MonoBehaviour
{

    public GameObject objectManager;
    public GameObject[] enemies;
    public GameObject michi;

    // Start is called before the first frame update
    void Start()
    {
        michi = GameObject.FindWithTag("Player");
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            foreach (var enem in enemies){
                Destroy(enem);
            }
            michi.SendMessage("incrementarPuntaje", enemies.Length);
            Destroy(this.gameObject);
        }
    }
}
