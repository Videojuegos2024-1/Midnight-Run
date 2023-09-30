using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImperviousPotion : MonoBehaviour
{

    public GameObject michi;
    public int vidasTemp;
    void Start(){
        vidasTemp = 0;
        GameObject.Find("MrMidnight");
    }

    public void vidasIniciales(int vidasActuales){
        vidasTemp = vidasActuales;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            Destroy(this.gameObject);
        }
    }

    IEnumerator imperviousness(){
        yield return new WaitForSeconds(10.0f);
    }

}
