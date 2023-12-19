using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody myRigidbody;

    // Update is called once per frame
    void Update()
    { 
            if (Input.GetKey(KeyCode.RightArrow))

            {
                myRigidbody.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
            }
            if (Input.GetKey(KeyCode.LeftArrow))

            {
                myRigidbody.AddForce(new Vector3(-1, 0, 0), ForceMode.Impulse);
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        myRigidbody = GetComponent<Rigidbody>();
    }
}  