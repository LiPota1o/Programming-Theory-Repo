using UnityEngine;

public class zombie : enemy
{
    public override void TakeDamage(int damage)
    {
        health -= damage / 2; // Zombie takes less damage
        if (health <= 0)
        {
            Die();
        }
    }
}
