using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    private float health;

    public void SetMaxHealth(float health)
    {
        this.health = health;
        slider.maxValue = health;
        slider.value = health;
    }
    
    public void SetHealth(float health)
    {
        this.health = health;
        slider.value = health;
    }
    
    public float GetHealth()
    {
        return health;
    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        slider.value -= amount;
    }

    public void Die()
    {
        health = 0;
        slider.value = 0;
    }
    
}
