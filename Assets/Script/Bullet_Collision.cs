using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collision : MonoBehaviour
{
    private GameObject attackable;
    private GameObject player;


    // Start is called before the first frame update
    void Start()
    {
    
        player = GameObject.FindGameObjectWithTag("Player");
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {

    }


private void OnTriggerEnter2D(Collider2D collision){

 var attackable = collision.GameObject.GetComponent<Attackable>();

if(attackable){



} 
}

}
