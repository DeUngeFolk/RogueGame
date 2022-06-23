using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using hp.HealthSystemCM;

public class Necromancer : MonoBehaviour, IGetHealthSystem
{
    private HealthSystem healthSystem;

    public float maxHealth;

    public GameObject player;

    private int dmgStat;

    float IGetHealthSystem.maxHealth => maxHealth;

    private void Awake()
    {
        healthSystem = new HealthSystem(maxHealth);
        healthSystem.OnDead += HealthSystem_OnDead;
    }

    private void Start()
    {
        player = GameObject.Find("Player");
        dmgStat = player.GetComponent<PlayerStats>().dmgStat;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        // check to see if enemy got hit by  a bullet, if yes take 5dmg.
        GameObject bullet = col.gameObject;
       int test = bullet.GetComponent<Bullet_Collision>().damage;

        if (bullet.name == "Bullet(Clone)")
        {
            Damage (dmgStat);
            // Debug.Log("enemy has taken 5 dmg");
        }
    }

    public void Damage(int damage)
    {
        DamagePopup.Create(transform.position + new Vector3(8, 0), damage);
        healthSystem.Damage (damage);
    }

    private void HealthSystem_OnDead(object sender, System.EventArgs e)
    {
        ScoreScript.scoreValue += 1;
        Destroy (gameObject);
    }

    public HealthSystem GetHealthSystem()
    {
        return healthSystem;
    }
}
