using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public GameObject[] Heart;
    public int life;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    Vector2 Movement;
    AudioSource audiosrc;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //float directionY = Input.GetAxisRaw("Vertical");
        //playerDirection = new Vector2(0, directionY).normalized;
        Movement.x = Input.GetAxisRaw("Horizontal") * playerSpeed;
        Movement.y = Input.GetAxisRaw("Vertical") * playerSpeed;

    }

    private void FixedUpdate()
    {
        //rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
        rb.velocity = new Vector2(Movement.y, rb.velocity.y);
        rb.velocity = new Vector2(Movement.x, rb.velocity.x);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "arrow")
        {
            audiosrc.Play();
            life -= 1;
            if (life < 1)
            {
                Destroy(Heart[0].gameObject);
                Destroy(this.gameObject);
            }
            else if (life < 2) {
                Destroy(Heart[1].gameObject);
            }
            else if (life < 3) {
                Destroy(Heart[2].gameObject);
            }
        }
    }
}
