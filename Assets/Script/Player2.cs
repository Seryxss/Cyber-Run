using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Player2 : MonoBehaviour
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
        //float directionY = Input.GetAxisRaw("Vertical");
        //playerDirection = new Vector2(0, directionY).normalized;

        rb.velocity = new Vector2(MovementX * playerSpeed, MovementY * playerSpeed);
        if (Input.GetKey(KeyCode.I))
        {
            MovementY = 1;
        }
        if (Input.GetKey(KeyCode.K))
        {
            MovementY = -1;
        }
        if (Input.GetKey(KeyCode.J))
        {
            MovementX = -1;
        }
        if (Input.GetKey(KeyCode.L))
        {
            MovementX = 1;
        }

        if (Input.GetKeyUp(KeyCode.I) || Input.GetKeyUp(KeyCode.K))
        {
            MovementY = 0;
        }
        if (Input.GetKeyUp(KeyCode.J) || Input.GetKeyUp(KeyCode.L))
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
