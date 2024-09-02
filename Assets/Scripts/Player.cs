using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    private float horizontal;
    private bool isFacinRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        this.horizontal = Input.GetAxis("Horizontal");

        this.rb.velocity = new Vector2(horizontal * 8f, this.rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.rb.AddForce(Vector2.up * 15f, ForceMode2D.Impulse);
        }

        Flip();
    }
    
    private void Flip()
    {
        if (isFacinRight && horizontal < 0f || !isFacinRight && horizontal > 0f)
        { 
            isFacinRight = !isFacinRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1;
            transform.localScale = localScale;
        }

    }
}
