using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthComponent : MonoBehaviour
{
    public float maxHealth = 100f;
    private float health;
    public bool hasHealthBar;
    public Image healthBar;


    //public void ApplyDamage(float amount)
    //{
    //    Health -= amount;

    //    if (Health <= 0)
    //        Destroy(gameObject);
    //}

    void Start()
    {
        health = maxHealth;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            health--;

            if (health <= 0)
            Destroy(gameObject);
        }

        if (hasHealthBar)
        {
            healthBar.fillAmount = health / maxHealth;
        }
    }
}
