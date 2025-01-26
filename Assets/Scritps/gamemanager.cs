using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class gamemanager : MonoBehaviour
{
    // Список врагов
    public List<enemy> enemies = new List<enemy>();
    // Список оружия
    public List<weapon> weapons = new List<weapon>();

    void Start()
    {
        // Добавляем врагов в список
        enemies.Add(new zombie());
        enemies.Add(new robot());

        // Добавляем оружие в список
        weapons.Add(new gun());
        weapons.Add(new bow());
    }

    void Update()
    {
        // Демонстрация полиморфизма с врагами
        foreach (enemy enemy in enemies)
        {
            enemy.TakeDamage(10); // Все враги получат урон
        }

        // Демонстрация полиморфизма с оружием
        foreach (weapon weapon in weapons)
        {
            weapon.Shoot(); // Все оружия выполнят выстрел
        }
    }
}
