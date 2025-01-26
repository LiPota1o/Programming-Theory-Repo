using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class gamemanager : MonoBehaviour
{
    // List of enemies
    public List<enemy> enemies = new List<enemy>();
    // List of weapons
    public List<weapon> weapons = new List<weapon>();

    void Start()
    {
        // Adding enemy to the list
        enemies.Add(new zombie());
        enemies.Add(new robot());

        // Adding weapon to the list
        weapons.Add(new gun());
        weapons.Add(new bow());
    }

    void Update()
    {
        // POLYMORPHISM for enemy
        foreach (enemy enemy in enemies)
        {
            enemy.TakeDamage(10); // All enemies take damage
        }

        // POLYMORPHISM for weapon
        foreach (weapon weapon in weapons)
        {
            weapon.Shoot(); // All weapons shoot
        }
    }
}
