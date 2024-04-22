using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso1 : MonoBehaviour
{
    private AudioSource musi;
    // Start is called before the first frame update
    void Start()
    {
        musi = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            musi.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            musi.Stop();
        }
    }
}
