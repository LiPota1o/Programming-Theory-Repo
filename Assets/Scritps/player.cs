using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private int health = 100;

    // ����� ��������� �����
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // ����� ��������� �������� ��������
    public int GetHealth()
    {
        return health;
    }

    // ����� ������ ������
    private void Die()
    {
        Debug.Log("Player died!");
    }
}
