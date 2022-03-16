using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float health;
    public float maxhealth;

    public GameObject healthBarUI;

    public GameObject spider;
    public Slider slider;

    void start()
    {
        health = maxhealth;
        slider.value = CalculateHealth();
    }
    void update()
    {
        slider.value = CalculateHealth();

        if (health < maxhealth)
        {
            healthBarUI.SetActive(true);
        }
        if (health <= 0)
        {
            Destroy(spider);
        }
        if (health > maxhealth)
        {
            health = maxhealth;
        }
    }
    float CalculateHealth()
    {
        return health / maxhealth;
    }

    public void SetMaxHealth(int health)
    {

        slider.maxValue = health;
        slider.value = health;

    }

    public void SetHealth(int health)
    {

        slider.value = health;

    }


}
