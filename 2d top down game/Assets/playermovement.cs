using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class playermovement : MonoBehaviour
{
    public float speed = 3f;
    public Rigidbody2D rb;
    public Camera cam;
    Vector2 movement;
    Vector2 MousePos;
        void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        
        MousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }

    
    void FixedUpdate()
    {
       rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime); 
        
        Vector2 lookDir = MousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f; 
        rb.rotation = angle;


    }
}
