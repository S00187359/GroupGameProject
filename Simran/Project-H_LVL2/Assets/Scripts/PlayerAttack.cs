using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Weapon[] weapons;
    int activeWeaponIndex = -1;
    Weapon activeWeapon;

    public float laserSpeed = 5;
    public GameObject bulletObject;
    public Transform spawnPoint;
    public Transform spawnPoint2;
    public float firerate;
    private float timeToShoot;

    



    public GameObject laserSource;
    public GameObject laserSource2;

    void Start()
    {
        SetActiveWeapon(0);
    }

    void Update()
    {

     

        if (Input.GetButtonDown("Fire1"))
        {
           

            if (timeToShoot <= Time.time)
            {
                GameObject go = Instantiate(bulletObject, laserSource.transform.position, this.transform.rotation);
                GameObject go2 = Instantiate(bulletObject, laserSource2.transform.position, this.transform.rotation);
                go.GetComponent<Bullet>().speed = laserSpeed;
                go2.GetComponent<Bullet>().speed = laserSpeed;
                go.GetComponent<Rigidbody>().velocity = (spawnPoint.forward * laserSpeed) * Time.deltaTime;
                go2.GetComponent<Rigidbody>().velocity = (spawnPoint2.forward * laserSpeed) * Time.deltaTime;
                timeToShoot = Time.time + firerate;

            }
               
            
            if (activeWeapon)
            {
                activeWeapon.Fire(transform.position);

            }
        }

      

    }



    private void HandleWeaponSwitching()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetActiveWeapon(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetActiveWeapon(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetActiveWeapon(2);
        }



    }

    private void SetActiveWeapon(int index)
    {
        if (index >= 0 && index <= weapons.Length)
        {
            if (activeWeapon)
            {
                Destroy(activeWeapon.gameObject);
            }

            activeWeapon = Instantiate(weapons[index], transform);
            activeWeaponIndex = index;

        }
    }
}
