using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 100f;
    public GameObject deathParticle;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0f)
        {
            Die ();
        }
    }

    void Die()
    {
        Destroy(gameObject);

        Instantiate(deathParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
