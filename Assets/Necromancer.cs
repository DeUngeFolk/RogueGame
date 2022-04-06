using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necromancer : MonoBehaviour, IEnemy
{
    

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log (currentHealth);

        if (0 >= currentHealth)
        {
            death();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // check to see if enemy got hit by  a bullet, if yes take 5dmg.
        GameObject bullet = col.gameObject;

        if (bullet != null)
        {
            takeDamage(5);
            Debug.Log("enemy has taken 5 dmg");
        }
    }

    void death()
    {
        Destroy (gameObject);
    }

    public bool alive { get; private set; }

    public int currentHealth { get; private set; }

    public void takeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    }
}
