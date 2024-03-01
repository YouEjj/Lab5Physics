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
    public GameObject genblo;
    public GameObject cubeHolder;
    //public GameObject cubeHolder;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "prinPlan")
        {
            //Debug.Log("Delete this Sphere");
            Destroy(this.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("gen"));
            Destroy(GameObject.FindGameObjectWithTag("Holder"));

            GameObject[] cubes = GameObject.FindGameObjectsWithTag("Cube");


            foreach (GameObject cube in cubes)
            {
                Destroy(cube);

            }
            Debug.Log("Score : 0 Game Over !");
            Instantiate(sphere, new Vector3(3.5f, 4.33f, -1.15f), Quaternion.identity);
            Instantiate(genblo, new Vector3(3.850523f, 5.812638f, -0.6358458f), Quaternion.identity);
            Instantiate(cubeHolder, new Vector3(3.78f, 0.5f, -1.15f), cubeHolder.transform.rotation);
        }




    }
}
