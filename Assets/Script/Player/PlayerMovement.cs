using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Ходьба")]
    [SerializeField]private float PlayerSpeed = 5f;
    private float moveX;
    private Rigidbody2D rb;
    [Header("Прыжок")]
    [SerializeField]private float JumpForce = 5f;
    private bool IsGround;
    [Header("Ключ")]
    private bool IsKeySpace;
    [Header("Анимация")]
    private Animator animator;
    private SpriteRenderer sr;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        IsGround = true;
    }
    private void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        if(Input.GetKey(KeyCode.Space) && IsGround == true)
        {
            IsKeySpace = true;
        }
        animator.SetFloat("Speed", Mathf.Abs(moveX));
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveX * PlayerSpeed, rb.velocity.y);
        if(IsKeySpace == true)
        {
            Jump();
            IsKeySpace = false;
        }
        if(moveX > 0f)
        {
            sr.flipX = false;
        }else if (moveX < 0f)
        {
            sr.flipX = true;
        }
    }
    private void Jump()
    {
        rb.AddForce(new Vector2(rb.velocity.x, JumpForce), ForceMode2D.Impulse);
        IsGround = false;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            IsGround = false;
        }
    }
}
