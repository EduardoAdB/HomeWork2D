using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private bool isGrounded; // Check if the player is on the ground

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
    }

    void Update()
    {
        // Get raw horizontal input
        float moveX = Input.GetAxisRaw("Horizontal"); // Left/Right (A/D or LeftArrow/RightArrow)

        // Apply movement
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        // Flip sprite based on movement direction
        if (moveX > 0)
            spriteRenderer.flipX = false; // Facing right
        else if (moveX < 0)
            spriteRenderer.flipX = true;  // Facing left

        // Jump when pressing Space and player is grounded
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false; // Prevent double jumping
        }
    }

    // Detect ground collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground")) // Ensure ground objects have the "Ground" tag
        {
            isGrounded = true;
        }
    }
}
