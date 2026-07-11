using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;


public class EnemyAtoB : MonoBehaviour
{
    [Header("Точки ходьбы")]
    [SerializeField]private Transform transformA;
    [SerializeField]private Transform transformB;
    [SerializeField]private Transform currentTarget;
    [Header("Ходьба противника")]
    [SerializeField]private float SpeedEnemy = 3f;
    private Vector2 InputVector;
    private Rigidbody2D rb;
    private PlayerHealth playerHealth;
    private SpriteRenderer sr;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        currentTarget = transformB;
    }
    private void Update()
    {
        Vector2 direction = (currentTarget.position - transform.position).normalized;
        rb.velocity = direction * SpeedEnemy;
        float distance = Vector2.Distance(transform.position, currentTarget.position);
        if (distance <= 1f)
        {
            if(currentTarget == transformA)
            {
                currentTarget = transformB;
            }
            else 
            {
                currentTarget = transformA;
            }
        }
        if(direction.x > 0.01f)
        {
            sr.flipX = false;
        }
        else if(direction.x < -0.01f)
        {
            sr.flipX = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            if(playerHealth != null)
            {
                playerHealth.TakeDamage(1);
            }
        }
    }
}
