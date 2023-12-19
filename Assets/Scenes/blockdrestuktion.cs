using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockdrestuktion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()

    {

    }
    int hp = 1;
    // Update is called once per frame
    void Update()
    {

       
    }

    private void OnCollisionEnter(Collision collision)
    {
         GameObject otherGameObject = collision.gameObject;
        bollcolission hitEnemy = otherGameObject.GetComponent<bollcolission>();

        if (hp != 0)
        {
            Destroy(gameObject);
        }
    }
}