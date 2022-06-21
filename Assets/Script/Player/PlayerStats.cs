using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using hp.HealthSystemCM;

public class PlayerStats : MonoBehaviour, IGetHealthSystem

{
    public int maxHealth;
   
    float _timeColliding;

   
    public float timeThreshold = 1f;

private HealthSystem healthSystem;
  
     private void Awake()
        {
            healthSystem = new HealthSystem(maxHealth);
            healthSystem.OnDead += HealthSystem_OnDead;
        }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        _timeColliding = 0f;

        Debug.Log("enemy started colliding with player");

        if (col.gameObject.tag == "Enemy")
        {
            Damage(5);
            Debug.Log("player has been hit!");
        }
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            // If the time is below the threshold, add the delta time
            if (_timeColliding < timeThreshold)
            {
                _timeColliding += Time.deltaTime;
            }
            else
            {
                // Time is over theshold, player takes damage
                Damage(5);

                // Reset timer
                _timeColliding = 0f;
            }
        }
    }

    void death()
    {
        Destroy (gameObject);
    }

    public void Damage(int damage)
    {
        healthSystem.Damage(damage);
        
    }
    private void HealthSystem_OnDead(object sender, System.EventArgs e)
        {
            Destroy (gameObject);
        }

    public HealthSystem GetHealthSystem()
    {
        return healthSystem;
}}
