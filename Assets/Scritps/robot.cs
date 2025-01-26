using UnityEngine;

public class robot : enemy
{
    public override void TakeDamage(int damage)
    {
        health -= damage; // Робот получает обычный урон
        if (health <= 0)
        {
            Die();
        }
    }
}
