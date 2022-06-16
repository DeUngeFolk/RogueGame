using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Collision : MonoBehaviour
{
    private GameObject player;

    private int seconds;

    // Start is called before the first frame update
    void Start()
    {
        seconds = 0;
        player = GameObject.Find("Player");
        Physics2D
            .IgnoreCollision(player.GetComponent<Collider2D>(),
            GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        seconds+=1;
        if (seconds > 60*5) // f*s - f=60frames, s= amount of seconds before despawn
        {
            Destroy (gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("hello");
        IAttackable attackable = col.GetComponent<IAttackable>();

        if (attackable != null)
        {
            Destroy (gameObject);
        }
    }
}
