using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    Rigidbody Ball;
    // Start is called before the first frame update
    void Start()
    {
        Ball = GetComponent<Rigidbody>();
        Ball.AddForce(new Vector3(0, -3, 0), ForceMode.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10;
        Ball.velocity = Ball.velocity.normalized * speed;
    }
}

  
