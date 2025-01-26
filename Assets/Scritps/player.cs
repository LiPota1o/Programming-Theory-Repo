using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int health = 100;

    // Method for taking damage
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Method for getting player health
    public int GetHealth()
    {
        return health;
    }

    // Method for player's death
    private void Die()
    {
        Debug.Log("Player died!");
    }
}
