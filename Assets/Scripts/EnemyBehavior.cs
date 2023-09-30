using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public GameObject screen;

    // Start is called before the first frame update

    public float speed;
    void Update()
    {
        speed += (float).1 * Time.deltaTime;
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            screen.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
