using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
   
    private Rigidbody rb;
    private AudioSource sounds;

    // Start is called before the first frame update
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        sounds = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {



    }
    void FixedUpdate()
    {
        
        
        if (rb.useGravity == true)
        {
            Debug.Log(rb.useGravity);
            if (!sounds.isPlaying) 
            {
                sounds.Play();
            }
        }
    }
}
