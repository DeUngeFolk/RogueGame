using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Powerups/HealthBuff")]
public class HealthBuff : PowerUpEffect
{
    public float amount;
    public GameObject player;
    public override void Apply(GameObject player)
    {
        player.GetComponent<PlayerStats>().healPlayer(5);
    }
}
