using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class piso4 : MonoBehaviour
{
    private AudioSource musi4;
    public bool cambio;
    public float nu;
    // Start is called before the first frame update
    void Start()
    {
        musi4 = GetComponent<AudioSource>();
        nu = 0;
        cambio = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (cambio==true)
        {
            nu = nu + Time.deltaTime;
            if (nu >= 8)
            {
                cambioo();
            }
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "player")
        {
            musi4.Play();
            cambio = true;
        }
    }
    public void cambioo()
    {
        SceneManager.LoadScene("nivel2");
    }
   
}
