using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour, IAttackable
{
    public int maxHealth { get; set; }

    public int setMaxHealth;

    public bool alive { get; private set; }

    public int currentHealth { get; private set; }

    // damage timer variables
    // Timer to track collision time
    float _timeColliding;

    // Time before damage is taken, 1 second default
    public float timeThreshold = 1f;

  //  public HealthBar healthBar;

    // Start is called before the first frame update
   // public Transform pfHealthBar;
    void Start()
    {

      //  Transform healthBarTransform = Instantiate(pfHealthBar, new Vector3(0,-0.8f),Quaternion.identity);
       // healthBarTransform.transform.parent = gameObject.transform;
       // HealthBar healthBar = healthBarTransform.GetComponent<HealthBar>();

      //  HealthSystem healthSystem = new HealthSystem(100);
        maxHealth = setMaxHealth;
        currentHealth = maxHealth;
    //    healthBar.SetMaxHealth (maxHealth);
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
        _timeColliding = 0f;

        Debug.Log("enemy started colliding with player");

        if (col.gameObject.tag == "Enemy")
        {
            takeDamage(5);
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
                takeDamage(5);

                // Reset timer
                _timeColliding = 0f;
            }
        }
    }

    void death()
    {
        Destroy (gameObject);
    }

    public void takeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
     //   healthBar.SetHealth (currentHealth);
    }
}
