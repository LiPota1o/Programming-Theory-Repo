using UnityEngine;

public class zombie : enemy
{
    public override void TakeDamage(int damage)
    {
        health -= damage / 2; // Зомби получает меньше урона
        if (health <= 0)
        {
            Die();
        }
    }
}
