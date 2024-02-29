using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Holder")
        {
            Debug.Log("A Collision has been happened");
            this.GetComponent<Rigidbody>().AddForce(1, 700, 1);
        }

        
        if (collision.gameObject.CompareTag("planA"))
        {
            Debug.Log("A collision has occurred with the planB.");

            // Calculate the opposite direction of the collision normal
            Vector3 oppositeDirection = -collision.contacts[0].normal;

            // Add a force in the opposite direction of the collision normal
            GetComponent<Rigidbody>().AddForce(oppositeDirection * 600f);
        }
        if (collision.gameObject.CompareTag("planA"))
        {
            Debug.Log("A collision has occurred with the planB.");

            // Calculate the opposite direction of the collision normal
            Vector3 oppositeDirection = -collision.contacts[0].normal;

            // Add a force in the opposite direction of the collision normal
            GetComponent<Rigidbody>().AddForce(oppositeDirection * 600f);
        }
    
    }
}
