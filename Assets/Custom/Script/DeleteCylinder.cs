using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DeleteCylinder : MonoBehaviour
{
    
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

        //Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "Floor"|| collision.gameObject.tag == "Controller")
        {
            Destroy(gameObject, 0.1f);
        }

    }
}