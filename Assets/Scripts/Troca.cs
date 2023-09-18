using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troca : MonoBehaviour
{
    public float speed, rotationSpeed;
    private float vm, hm;
    private bool ym;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
        rotationSpeed = 25;
    }

    // Update is called once per frame
    void Update()
    {
        vm = Input.GetAxis("Vertical");
        hm = Input.GetAxis("Horizontal");
        ym = Input.GetKey("space");

        this.transform.Translate(Time.deltaTime * speed * hm, 0,0);
        //this.transform.Rotate(Vector3.up, rotationSpeed*Time.deltaTime*hm);
    }
}
