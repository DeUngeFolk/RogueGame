using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{

    public int PlayerHealth=30;
    int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        print(PlayerHealth);
        
    }

    void OnCollisionEnter(Collision _collision){
        if(_collision.gameObject.tag=="enemy"){
            print("u take damage");
        }
    }

   
}
