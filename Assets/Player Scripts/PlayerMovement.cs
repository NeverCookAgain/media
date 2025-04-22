using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 7f;
    public float acceleration = 15f;
    public float deceleration = 15f;
    public float friction = 20f;

    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator animator;
    private bool isCarrying = false; 

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

private int facingDirection = 1; 
// 1 for right, 0 for left

void Update()
{
    moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    moveInput = moveInput.normalized;

    
    if (moveInput.x > 0)
    {
        facingDirection = 1;
    }
    else if (moveInput.x < 0)
    {
        facingDirection = 0;
    }

    animator.SetInteger("facing", facingDirection);

    bool isMoving = moveInput.magnitude > 0.01f;
    animator.SetBool("isMoving", isMoving);
    animator.SetBool("isCarrying", isCarrying);
}


    void FixedUpdate()
    {
        ApplyMovement();
    }

    void ApplyMovement()
{
    Vector2 targetVelocity = moveInput * moveSpeed;
    rb.velocity = targetVelocity;

    if (moveInput.magnitude < 0.01f)
    {
        ApplyFriction();
    }
}
    void ApplyFriction()
    {
        if (rb.velocity.magnitude > 0.01f)
        {
            float frictionForce = Mathf.Min(rb.velocity.magnitude, friction * Time.fixedDeltaTime);
            rb.velocity -= rb.velocity.normalized * frictionForce;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
    public void SetCarryingState(bool carrying)
    {
        isCarrying = carrying;
        animator.SetBool("isCarrying", carrying);
    }
}