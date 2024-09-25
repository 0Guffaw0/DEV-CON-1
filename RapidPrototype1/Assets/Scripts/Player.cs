using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private SpriteRenderer sr;
    private bool isInBox = false;
    private float spaceHoldTime = 0f;
    public float maxHoldTime = 3f;

    public float runSpeed = 10f;
    public LayerMask groundLayer;
    public TextMeshProUGUI timerText;

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
        UpdateTimerUI();
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
            rb2d.gravityScale = 5;
        }
        else if (Input.GetKey(KeyCode.Space) && spaceHoldTime < maxHoldTime)
        {
            rb2d.gravityScale = -1;
            spaceHoldTime += Time.deltaTime;
        }
        else
        {
            rb2d.gravityScale = 5;
            if (!Input.GetKey(KeyCode.Space))
            {
                spaceHoldTime = 0f;
            }
        }
    }

    void UpdateTimerUI()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timerText.text = "LiftTime: " + (maxHoldTime - spaceHoldTime).ToString("F2") + "s";
        }
        else
        {
            timerText.text = "LiftTime: " + maxHoldTime.ToString("F2") + "s";
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
