using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfCaught : MonoBehaviour
{
    private bool isInContact =false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

       
        if (collision.gameObject.tag == "Cylinder")
        {
            isInContact = true;
        }
        else
        {
            isInContact = false;
        }

    }

}
