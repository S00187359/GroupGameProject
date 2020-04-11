using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
   

    public float laserSpeed = 5;
    public GameObject bulletObject;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public float firerate;
    private float timeToShoot;
    public int bulletCount = 100;


    public GameObject laserSource;
    public GameObject laserSource2;

    void Start()
    {
        
    }

    void Update()
    {

     

        if (Input.GetButtonDown("Fire1"))
        {
           

            if (timeToShoot <= Time.time && bulletCount > 0)
            {
                bulletCount -= 2;
                GameObject go = Instantiate(bulletObject, laserSource.transform.position, this.transform.rotation);
                GameObject go2 = Instantiate(bulletObject, laserSource2.transform.position, this.transform.rotation);
                go.GetComponent<Bullet>().speed = laserSpeed;
                go2.GetComponent<Bullet>().speed = laserSpeed;
                go.GetComponent<Rigidbody>().velocity = (spawnPoint.forward * laserSpeed) * Time.deltaTime;
                go2.GetComponent<Rigidbody>().velocity = (spawnPoint2.forward * laserSpeed) * Time.deltaTime;
                timeToShoot = Time.time + firerate;

            }
               
            
           
        }

      

    }

   
}
