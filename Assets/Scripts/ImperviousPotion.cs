using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImperviousPotion : MonoBehaviour
{

    public GameObject michi;
    public int vidasTemp;
    void Start(){
        michi = GameObject.FindWithTag("Player");
        vidasTemp = 0;
    }

    public void vidasIniciales(int vidasActuales){
        vidasTemp = vidasActuales;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player"){
            michi.SendMessage("incrementarVidas");
        }
    }

}
