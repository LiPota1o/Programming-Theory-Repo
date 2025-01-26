using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class gamemanager : MonoBehaviour
{
    // ������ ������
    public List<enemy> enemies = new List<enemy>();
    // ������ ������
    public List<weapon> weapons = new List<weapon>();

    void Start()
    {
        // ��������� ������ � ������
        enemies.Add(new zombie());
        enemies.Add(new robot());

        // ��������� ������ � ������
        weapons.Add(new gun());
        weapons.Add(new bow());
    }

    void Update()
    {
        // ������������ ������������ � �������
        foreach (enemy enemy in enemies)
        {
            enemy.TakeDamage(10); // ��� ����� ������� ����
        }

        // ������������ ������������ � �������
        foreach (weapon weapon in weapons)
        {
            weapon.Shoot(); // ��� ������ �������� �������
        }
    }
}
