using UnityEngine;

public class robot : enemy
{
    public override void TakeDamage(int damage)
    {
        health -= damage; // ����� �������� ������� ����
        if (health <= 0)
        {
            Die();
        }
    }
}
