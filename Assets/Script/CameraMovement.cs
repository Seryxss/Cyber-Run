using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    public float maxSpeed;
    // Update is called once per frame

    void Start()
    {
        Time.timeScale = 1;
    }

    void Update()
    {
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);

        if (cameraSpeed < maxSpeed)
        {
            cameraSpeed += 0.5f * Time.deltaTime;
            //cameraSpeed += 0.5f;
        }
    }
}
