using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicationCube : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject block;
    public int width = 20;
    public int height = 20;


    public Material blueMaterial;
    public Material greenMaterial;
    public int a = 1;
    void Start()
    {
        for (int y = 7; y < height; ++y)
        {
            for (float x = 6.3f; x > -width; x -= 3.05f)
            {
                Material materialToUse = (a % 2 == 0) ? blueMaterial : greenMaterial;
                GameObject newBlock = Instantiate(block, new Vector3(x, y, -1.15f), block.transform.rotation);
                newBlock.GetComponent<Renderer>().material = materialToUse;
                a++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
