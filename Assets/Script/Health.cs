using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject[] hearts;
    public int life;
    public bool dead;


    // Start is called before the first frame update
    void Start()
    {
        life = hearts.Length;    
    }

    public void takeDamage(int d)
    {
        if(life > 1)
        {
            life -= d;
            Destroy(hearts[life].gameObject);
            if(life < 1)
            {
                dead = true;
            }
        }
    }
}
