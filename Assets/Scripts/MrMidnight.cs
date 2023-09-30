using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrMidnight : MonoBehaviour
{
    public float speed;
    private float hm;
    private bool isGrounded;
    public Rigidbody rb;
    public Vector3 jump;
    public float jumpForce = 2.0f;
    private int vidas;
    public GameObject screen;
    private int puntaje;
    private int fairies;
    private float x;
    private float y;
    Vector3 newPos;
    

    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
        fairies = 0;
        puntaje = 0;
        vidas = 2;
        rb = GetComponent<Rigidbody>();
        speed = 10;
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay(){
        isGrounded = true;
    }
    void OnCollisionExit(){
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        x = this.transform.position.x;
        y = this.transform.position.y;
        newPos = new Vector3(x, y, 0);
        this.transform.position = newPos;
        hm = Input.GetAxis("Horizontal");
        print(isGrounded);
        this.transform.Translate(Time.deltaTime * speed * hm * 1.3f, 0, 0);
        print(puntaje);
        print(vidas);
        print(fairies);
        if(Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Enemy":
                Destroy(collision.gameObject, 0f);
                vidas--;
                if(vidas == 0)
                    screen.SetActive(true);
                break;
            case "Fairy":
                Destroy(collision.gameObject, 0f);
                puntaje += 500;
                if(fairies == 3){
                    vidas++;
                    fairies = 0;
                }
                else{
                    fairies++;
                }
                break;
            default:
                break;
        }
    }


}


