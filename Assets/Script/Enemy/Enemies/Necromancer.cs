using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace hp.HealthSystemCM
{
    public class Necromancer : MonoBehaviour, IGetHealthSystem
    {
        private HealthSystem healthSystem;
        public float maxHealth;

        // Start is called before the first frame update
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
            // check to see if enemy got hit by  a bullet, if yes take 5dmg.
            GameObject bullet = col.gameObject;

            if (bullet.name == "Bullet(Clone)")
            {
                Damage();
                Debug.Log("enemy has taken 5 dmg");
            }
        }

        void death()
        {
            ScoreScript.scoreValue += 1;
            Destroy (gameObject);
        }

        public void Damage()
        {
            healthSystem.Damage(40);
        }

        private void HealthSystem_OnDead(object sender, System.EventArgs e)
        {
            Destroy (gameObject);
        }

        public HealthSystem GetHealthSystem()
        {
            return healthSystem;
        }
    }
}
