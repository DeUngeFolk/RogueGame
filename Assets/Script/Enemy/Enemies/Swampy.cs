using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using hp.HealthSystemCM;

public class Swampy : MonoBehaviour, IGetHealthSystem
{
    private HealthSystem healthSystem;

    public float maxHealth;

    private void Awake()
    {
        healthSystem = new HealthSystem(maxHealth);
        healthSystem.OnDead += HealthSystem_OnDead;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // check to see if enemy got hit by  a bullet, if yes take 5dmg.
        GameObject bullet = col.gameObject;

        if (bullet.name == "Bullet(Clone)")
        {
            Damage(5);
            Debug.Log("enemy has taken 5 dmg");
        }
    }

    public void Damage(int damage)
    {
        healthSystem.Damage (damage);
    }

    private void HealthSystem_OnDead(object sender, System.EventArgs e)
    {
        ScoreScript.scoreValue += 1;
        Destroy (gameObject);
    }

    public HealthSystem GetHealthSystem()
    {
        throw new System.NotImplementedException();
    }
}
