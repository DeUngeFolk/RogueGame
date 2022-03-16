using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_2D : MonoBehaviour
{

    public Vector2 speed = new Vector2(50, 50);
    public Animator animator;

    

    // Update is called once per frame
    void Update()
    {

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        animator.SetFloat("Speed", Mathf.Abs(inputX));

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

        

        // flip sprite:

        Vector3 characterScale = transform.localScale;
        if (inputX < 0)
        {
            characterScale.x = -1;

        }

        if (inputX > 0)
        {
            characterScale.x = 1;


        }

        transform.localScale = characterScale;



    }
}
