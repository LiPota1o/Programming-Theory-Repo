using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    protected int health = 50;

    // Method of enemy taking damage
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Method of enemy's death
    protected void Die()
    {
        Debug.Log("Enemy died!");
    }
}
