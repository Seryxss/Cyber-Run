using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player3 : MonoBehaviour
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
        if (Input.GetKey(KeyCode.UpArrow))
        {
            MovementY = 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            MovementY = -1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            MovementX = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            MovementX = 1;
        }

        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            MovementY = 0;
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            MovementX = 0;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "arrow")
        {
            audiosrc.Play();
            Destroy(this.gameObject);
        }
    }
}
