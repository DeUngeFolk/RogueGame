using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swampy : MonoBehaviour, IAttackable
{
    
   // public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 5;
        currentHealth = maxHealth;
      //  healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (0 >= currentHealth)
        {
            death();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // check to see if enemy got hit by  a bullet, if yes take 5dmg.
        GameObject bullet = col.gameObject;

        if (bullet.name == "Bullet(Clone)")
        {
            takeDamage(5);
            Debug.Log("enemy has taken 5 dmg");
        }
    }

    void death()
    {
        ScoreScript.scoreValue += 1;
        Destroy (gameObject);
    }

    
    public int maxHealth{get; private set;}
    public bool alive { get; private set; }

    public int currentHealth { get; private set; }

    public void takeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    //    healthBar.SetHealth(currentHealth);
    }
}