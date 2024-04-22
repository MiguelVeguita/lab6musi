using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso2 : MonoBehaviour
{
    private AudioSource musi2;
    // Start is called before the first frame update
    void Start()
    {
        musi2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            musi2.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            musi2.Stop();
        }
    }
}
