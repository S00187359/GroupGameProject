using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{

    Rigidbody body;
   
    public float Speed = 1;
    public float timer = 0;
    

    void Start()
    {
        body = GetComponent<Rigidbody>();
       
    }


    void Update()
    {
        if (timer <= 10)
        {
            body.velocity = new Vector3(0,3,0);
        }
        else if (timer >= 10 && timer <= 15)
        {
            body.velocity = new Vector3(0, 0, -1) * Speed;
        }
        else if (timer >= 15 && timer <= 17)
        {
            transform.Rotate(-.05f, 0, 0);
            body.velocity = new Vector3(0, 0, 0) * Speed;
        }
        else if (timer >= 17 && timer <= 20)
        {
            body.velocity = new Vector3(0, 150, -300) * Speed;
        }
        else
        {
            Destroy(gameObject);

        }

        timer += Time.deltaTime;
    }
}
