using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //this.GetComponent<Rigidbody>().AddForce(1, 500, 1);
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "sphere")
        {
            //Debug.Log("Delete this Block");
            Destroy(this.gameObject);
        }


        

    }
}
