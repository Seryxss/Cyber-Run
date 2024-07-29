using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backgroud : MonoBehaviour
{
    public float backgroundspeed;
    public float maxSpeed;
    public Renderer backgroundrenderer;

    // Update is called once per frame
    void Update()
    {
        backgroundrenderer.material.mainTextureOffset += new Vector2(backgroundspeed * Time.deltaTime, 0f);

        if(backgroundspeed < maxSpeed)
        {
            backgroundspeed += 0.1f * Time.deltaTime;
        }
    }
}
