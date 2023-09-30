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
    

    // Start is called before the first frame update
    void Start()
    {
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

    // Update is called once per frame
    void Update()
    {
        hm = Input.GetAxis("Horizontal");
        print(isGrounded);
        this.transform.Translate(Time.deltaTime * speed * hm * 1.3f, 0, 0);

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
                Destroy(collision.gameObject);
                vidas--;
                if(vidas == 0)
                    screen.SetActive(true);
                break;
            default:
                break;
        }
    }


}


