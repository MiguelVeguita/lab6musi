using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso3 : MonoBehaviour
{
    private AudioSource musi3;
    // Start is called before the first frame update
    void Start()
    {
        musi3 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            musi3.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            musi3.Stop();
        }
    }
}
