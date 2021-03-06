using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2D : MonoBehaviour
{
    public Vector2 speed = new Vector2(50, 50);

    public float speed2 = 1f;

    public Animator animator;

    public SpriteRenderer m_SpriteRenderer;

    bool flipX;

    // dash variables
    public Vector3 moveDirection;

    public float maxDashTime = 1.0f;

    public float dashSpeed = 1.0f;

    public float dashStoppingSpeed = 0.1f;

    private float currentDashTime;

    void start()
    {
        currentDashTime = maxDashTime;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", Mathf.Abs(inputX));

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate (movement);

        if (Input.GetKey(KeyCode.Space))
        {
            playerDash (movement);
        }

        // flip sprite:
        Vector3 characterScale = transform.localScale;
        if (inputX < 0)
        {
            m_SpriteRenderer.flipX = true;
        }

        if (inputX > 0)
        {
            m_SpriteRenderer.flipX = false;
        }

        transform.localScale = characterScale;
    }

    void playerDash(Vector3 movement)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            currentDashTime = 0.0f;
        }
        if (currentDashTime < maxDashTime)
        {
            moveDirection = new Vector3(0, 0, dashSpeed);
            currentDashTime += dashStoppingSpeed;
        }
        else
        {
            moveDirection = Vector3.zero;
        }
        transform.Translate (movement);
    }
}
