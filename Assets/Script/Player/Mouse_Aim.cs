using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Aim : MonoBehaviour
{
    public Rigidbody2D rb;

    public Camera cam;

    public Transform playerTransform;

    Vector2 mousePosition;

    // Update is called once per frame
    void Update()
    {
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        rb.position =
            new Vector2(playerTransform.position.x, playerTransform.position.y);
    }

    void FixedUpdate()
    {
        Vector2 lookDir = mousePosition - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
