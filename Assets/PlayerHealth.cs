using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;


    void Start()
    {
        currentHealth = maxHealth;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Need to make damage go down on hit once we have a hit
        {
            takeDamage(1);
        }
        
        void takeDamage(int damage)
        {
            currentHealth -= damage;
        }
    }
}
