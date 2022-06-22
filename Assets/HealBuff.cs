using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealBuff : MonoBehaviour
{
    public int amount;
    public GameObject player;


     void Start()
    {
        player = GameObject.Find("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Apply(player);
    }

     public void Apply(GameObject player)
    {
        
        player.GetComponent<PlayerStats>().healPlayer(amount);
    }
}
