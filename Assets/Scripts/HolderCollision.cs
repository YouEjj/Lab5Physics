using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class HolderCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int score = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Holder")
        {
            //Debug.Log("A Collision has been happened");
            this.GetComponent<Rigidbody>().AddForce(1, 700, 1);
        }

        
        if (collision.gameObject.CompareTag("planB"))
        {
            Debug.Log("A collision has occurred with the planB.");
            this.GetComponent<Rigidbody>().AddForce(100, 200, 1);

         
        }
        if (collision.gameObject.CompareTag("planA"))
        {
            Debug.Log("A collision has occurred with the planA.");
            this.GetComponent<Rigidbody>().AddForce(-100, 200, 1);
            
        }



        if (collision.gameObject.tag == "Cube")
        {
            score++;
            Debug.Log("Votre Score : " + score);
        }



    }
}
