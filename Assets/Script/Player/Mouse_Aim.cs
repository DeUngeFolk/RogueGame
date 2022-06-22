using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_Aim : MonoBehaviour
{
    public Rigidbody2D firePoint;
    public Camera cam;

    Vector2 mousePosition;


    // Update is called once per frame
    void Update()
    {


        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    void FixedUpdate()
    {

        Vector2 lookDir = mousePosition - firePoint.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        firePoint.rotation = angle;



    }
}
