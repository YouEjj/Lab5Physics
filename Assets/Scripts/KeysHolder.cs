using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysHolder : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed=50f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
}
