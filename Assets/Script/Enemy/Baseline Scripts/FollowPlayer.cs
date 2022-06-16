using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayer : MonoBehaviour
{
   // public Transform Player;
    public GameObject Player;
    private Transform playerTransform;

    private Rigidbody2D rb;

    public float moveSpeed = 5f;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = Player.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
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

        //   float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        // direction.Normalize();
        // movement = direction;
    }

    private void FixedUpdate()
    {
    }

    void moveCharacter(Vector2 direction)
    {
        rb
            .MovePosition((Vector2) transform.position +
            (direction * moveSpeed * Time.deltaTime));
    }
}