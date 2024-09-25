using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private SpriteRenderer sr;
    private bool isInBox = false;

    public float runSpeed = 10f;
    public LayerMask groundLayer;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        Movement(h);
        HandleGravity();
    }

    void Movement(float hSpeed)
    {
        float xVel = hSpeed * runSpeed;
        rb2d.velocity = new Vector2(xVel, rb2d.velocity.y);

        // Flip sprite based on direction
        if (hSpeed < 0)
        {
            sr.flipX = true;
        }
        else if (hSpeed > 0)
        {
            sr.flipX = false;
        }
    }

    void HandleGravity()
    {
        if (isInBox)
        {
            rb2d.gravityScale = 1;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            rb2d.gravityScale = -1;
        }
        else
        {
            rb2d.gravityScale = 5;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Soot"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("gravityBox"))
        {
            isInBox = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gravityBox"))
        {
            isInBox = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "endDoor")
        {
            SceneManager.LoadScene("theEnd");
        }
    }
}
