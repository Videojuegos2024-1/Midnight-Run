using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tracker : MonoBehaviour{

    public int contador;
    public TMP_Text tmp;
    
    void Start(){
        contador = 0;
    }

    public void actualizarPuntaje(float puntaje){
        contador = (int) (puntaje * 10);
        tmp.text = contador + "";
    }
    
    
}
