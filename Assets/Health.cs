using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    
public class Health : MonoBehaviour
{

    public Slider healthSlider;

    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
    }
    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }
}
