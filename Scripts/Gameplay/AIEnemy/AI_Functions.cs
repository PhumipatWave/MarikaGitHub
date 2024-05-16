using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AI_Functions : MonoBehaviour
{
    public AI_CheckCollision isCollision;

    public Rigidbody2D rb;
    public Transform groundCheck;
    public Transform wallCheck;

    public LayerMask playerLayer;
    public LayerMask groundLayer;
    public Vector2 direction;

    public bool isGround, isWall, isPlayer, facingRight = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        FlipSprite();
        PointCheck();
    }

    private void FixedUpdate()
    {
        MoveToPlayer();
        FallingGravity();
    }

    public void FallingGravity()
    {
        if (rb.velocity.y < 0f)
        {
            rb.velocity += Vector2.up * (-10f * Time.deltaTime);
        }
    }

    public void FlipSprite()
    {
        if (facingRight && direction.x <= 0f || !facingRight && direction.x >= 0f)
        {
            Vector2 localScale = transform.localScale;
            facingRight = !facingRight;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    public void MoveToPlayer()
    {
        if (isCollision.isPlayer)
        {
            direction = isCollision.player.position - transform.position;
            direction.Normalize();

            rb.velocity = new Vector2(direction.x * 3.25f, rb.velocity.y);
            //Debug.Log(direction);

            if (isCollision.player.position.y > transform.position.y && isWall)
            {
                Jump();
            }

            /*  #Attack
            
            if (isPlayer)
            {

            }
            */
        }
    }

    private void PointCheck()
    {
        isGround = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);

        isWall = Physics2D.OverlapCircle(wallCheck.position, 0.2f, groundLayer);

        isPlayer = Physics2D.OverlapCircle(wallCheck.position, 0.2f, playerLayer);
    }

    private void OnDrawGizmos()
    {
        if (isGround)
        {
            Gizmos.color = Color.green;
        }
        else if (!isGround)
        {
            Gizmos.color = Color.yellow;
        }

        Gizmos.DrawRay(groundCheck.position, Vector3.down);

        if (isWall)
        {
            Gizmos.color = Color.green;
        }
        else if (!isWall)
        {
            Gizmos.color = Color.red;
        }

        if (facingRight)
        {
            Vector3 rightPos = wallCheck.position + new Vector3(1f, 0f, 0f);

            Gizmos.DrawLine(wallCheck.position, rightPos);
        }
        else
        {
            Vector3 leftPos = wallCheck.position - new Vector3(1f, 0f, 0f);

            Gizmos.DrawLine(wallCheck.position, leftPos);
        }
    }

    public void Jump()
    {
        rb.velocity = Vector2.up * 6.5f;
    }
}
