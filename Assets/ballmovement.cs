using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditorInternal;
using UnityEngine;

public class ballmovement : MonoBehaviour

{
    [SerializeField]
    GameObject textGameObject;

    TextMeshProUGUI textcopoment;

     Rigidbody Ball;

    int lives = 3;
    
    void Start()
    {
        Ball = GetComponent<Rigidbody>();
        Ball.AddForce(new Vector3(0, -5, 0), ForceMode.Impulse);
        textcopoment = textGameObject.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        float speed = 9;
        Ball.velocity = Ball.velocity.normalized * speed;
        string livetext = "lives; " + lives;
        textcopoment.text = livetext;
        if (transform.position.y < 5.5) 
        {
            lives -= 1;
            transform.position = new Vector3(7, 10, 6);
        }
         if (lives == -1)
        {

            Destroy(gameObject);
        }


        


    }
    
}

