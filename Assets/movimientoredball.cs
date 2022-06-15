using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoredball : MonoBehaviour
{
    public float jumpheight = 5.0f;
    public bool salto;
    public bool hit;
    private Rigidbody rb;


   

    void Start()
    {
        salto = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, 0.1f);
        }

      

        if(transform.position.y <= -2)
        {
            transform.position = new Vector3(20, 1, 0);
        }

       


    }
    void OnCollisionStay(Collision Col)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpheight;

        }
    }

    void OnCollisionEnter(Collision collision)
    {
           
        
       

        if (collision.gameObject.name == "spike")
        {
            transform.position = new Vector3(20, 1, 0);
        }
        if (collision.gameObject.name == "spike2")
        {
            transform.position = new Vector3(20, 1, 0);
        }
    }


}
