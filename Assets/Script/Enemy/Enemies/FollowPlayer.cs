using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
   // public Transform Player;
    public GameObject Player;
    private Transform playerTransform;
    public float moveSpeed = 5f;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        playerTransform = Player.GetComponent<Transform>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = playerTransform.position - transform.position;
        transform.position =
            Vector2
                .MoveTowards(transform.position,
                playerTransform.position,
                moveSpeed * Time.deltaTime);

       
    }



}
