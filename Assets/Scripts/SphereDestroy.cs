using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject sphere;
    //public GameObject cubeHolder;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "prinPlan")
        {
            Debug.Log("Delete this Sphere");
            Destroy(this.gameObject);

            Instantiate(sphere, new Vector3(1.93f, 4.33f, -1.15f), Quaternion.identity);
            //Instantiate(cubeHolder, new Vector3(2.25f, 0.5f, -1.15f), cubeHolder.transform.rotation);
        }




    }
}
