using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player1 : MonoBehaviour
{
    public float playerSpeed;

    private Rigidbody2D rb;

    float MovementX;
    float MovementY;

    AudioSource audiosrc;

    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audiosrc = GetComponent<AudioSource>();

        MovementX = 0;
        MovementY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(MovementX * playerSpeed, MovementY * playerSpeed);
        if (Input.GetKey(KeyCode.W))
        {
            MovementY = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            MovementY = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            MovementX = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            MovementX = 1;
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            MovementY = 0;
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            MovementX = 0;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("arrow"))
        {
            audiosrc.Play();
            Destroy(this.gameObject);
        }
    }
}
