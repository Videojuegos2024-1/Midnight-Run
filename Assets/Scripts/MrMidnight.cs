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
    private float puntaje;
    private int fairies;
    private float x;
    private float y;
    Vector3 newPos;
    public GameObject trackerPuntaje;
    public GameObject trackerVidas;

    // Start is called before the first frame update
    void Start()
    {
        screen.SetActive(false);
        fairies = 0;
        puntaje = 0;
        vidas = 7;
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

    public void incrementarPuntaje(int amount){
        puntaje += amount;
    }

    public void sendLives(GameObject asker){
        asker.SendMessage("vidasIniciales", vidas);
    }

    // Update is called once per frame
    void Update()
    {
        trackerPuntaje.SendMessage("actualizarPuntaje", puntaje);
        trackerVidas.SendMessage("actualizarVidas", vidas);
        x = this.transform.position.x;
        y = this.transform.position.y;
        newPos = new Vector3(x, y, 0);
        this.transform.position = newPos;
        hm = Input.GetAxis("Horizontal");
        puntaje += .001f;
        this.transform.Translate(Time.deltaTime * speed * hm * 1.5f, 0, 0);
        print("Puntaje " + puntaje);
        //print("Hadas " + fairies);
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
                print("Vidas " + vidas);
                Destroy(collision.gameObject, 0f);
                vidas--;
                if(vidas <= 0)
                    screen.SetActive(true);
                break;
            case "Fairy":
                Destroy(collision.gameObject, 0f);
                puntaje += 5;
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


