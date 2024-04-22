using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audios : MonoBehaviour
{
    [SerializeField] private AudioClip newaudio;

    private AudioSource audiosou;
    // Start is called before the first frame update
    void Start()
    {
        audiosou = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void playsound()
    {

    }
    
}
