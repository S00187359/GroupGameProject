using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 10.00f;
    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    public virtual void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
