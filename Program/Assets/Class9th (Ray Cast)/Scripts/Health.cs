using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health;

    void Start()
    {
        health = 100;
    }

    public void OnDamage(float damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Destroy(gameObject);
        }

        Debug.Log("Health : " + health);
    }
}
