using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escenarios : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
