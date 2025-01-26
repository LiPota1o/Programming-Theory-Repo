using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int health = 100;

    // Метод получения урона
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Метод получения текущего здоровья
    public int GetHealth()
    {
        return health;
    }

    // Метод смерти игрока
    private void Die()
    {
        Debug.Log("Player died!");
    }
}
