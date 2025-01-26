using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    protected int health = 50;

    // Метод получения урона
    public virtual void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Метод смерти врага
    protected void Die()
    {
        Debug.Log("Enemy died!");
    }
}
