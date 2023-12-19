using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bollcolission : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    int hp = 3;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamage()
    {
        hp -= 1;
        if(hp == 0)
        {
            Destroy(gameObject);
        }
    }
}
