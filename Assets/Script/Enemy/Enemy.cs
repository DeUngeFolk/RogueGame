using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, Attackable
{
    public int maxHealth = 100;
    


    // Start is called before the first frame update
    void Start()
    {

        
    }

    public int CurrentHealth
    {

get; 

private set;

    }


   public void takeDamage(int damage)
    {

        CurrentHealth -= damage;


    }
}
