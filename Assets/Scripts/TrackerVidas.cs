using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrackerVidas : MonoBehaviour
{
    public int contador;
    public TMP_Text tmp;
    void Start()
    {
        contador = 7;
    }

    public void actualizarVidas(int vidas)
    {
        contador = vidas;
        tmp.text = contador + "";
    }
}
