using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeleter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "Fairy"){
            Destroy(other.gameObject, 0);
        }
    }

}
