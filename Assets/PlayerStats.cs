using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour, IAttackable
{

    public int maxHealth{get; private set;}

    public bool alive { get; private set; }

    public int currentHealth { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        currentHealth = maxHealth;
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
    }

    void death()
    {
        Destroy (gameObject);
    }

    

    public void takeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    }
}
