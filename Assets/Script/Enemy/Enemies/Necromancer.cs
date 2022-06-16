using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Necromancer : MonoBehaviour, IAttackable
{
    
  //  public HealthBar healthBar;
    public int setMaxHealth;
    public Transform pfHealthBar;

    // Start is called before the first frame update
    void Start()
    { // TODO: change the vector3 below, to figure out where to spawn healthbar based on enemy location.
        Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0,-0.8f),Quaternion.identity);
        healthBarTransform.transform.parent = gameObject.transform;
        HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();

        maxHealth = setMaxHealth;
        currentHealth = maxHealth;
    //    healthBar.SetMaxHealth(maxHealth);
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
