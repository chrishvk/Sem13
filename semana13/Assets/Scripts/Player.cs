using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;  //5
    public Rigidbody2D rb;
    private float directionY;
    private Vector2 direction;
    
    void Start()
    {
        
    }

    void Update()
    {
        directionY = Input.GetAxisRaw("Vertical");
        direction = new Vector2(0f, directionY).normalized;
    }

    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(0f, direction.y * speed);
        rb.position = new Vector2(rb.position.x, Mathf.Clamp(rb.position.y, -5f, 3.31f));
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("se chocó");
        Destroy(collision.gameObject);
    }
}
