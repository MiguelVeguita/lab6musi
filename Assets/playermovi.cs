using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovi : MonoBehaviour
{
    public AudioClip cam;
    private AudioSource pasos;
    private Rigidbody reig;
    public float x, y;
    private bool correr;
    // Start is called before the first frame update
    void Start()
    {
        pasos = GetComponent<AudioSource>();
        reig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

       
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!correr)
            {
                pasos.PlayOneShot(cam);
                correr = true;
            }
           
           
           
        }
        else
        {
            correr = false;
        }

    }
    private void FixedUpdate()
    {
        float yVelocity = reig.velocity.y;



        reig.velocity = new Vector3(x*5, yVelocity, y*5);
    }
    public void OnMovement(InputAction.CallbackContext context)
    {
        x = context.ReadValue<Vector3>().x;

        y = context.ReadValue<Vector3>().y;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "piso1")
        {
         
        }
    }
}
