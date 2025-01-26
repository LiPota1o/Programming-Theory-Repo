using UnityEngine;

public class robot : enemy
{
    public override void TakeDamage(int damage)
    {
        health -= damage; // Robot takes regular damage
        if (health <= 0)
        {
            Die();
        }
    }
}
