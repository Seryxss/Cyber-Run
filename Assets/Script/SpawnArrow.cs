using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArrow : MonoBehaviour
{
    public GameObject arrow;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timebetweenSpawn;
    private float spawnTime;
    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            spawn();
            spawnTime = Time.time + timebetweenSpawn;
        }
    }

    void spawn()
    {
        float randomx = Random.Range(minX, maxX);
        float randomy = Random.Range(minY, maxY);

        Instantiate(arrow, transform.position + new Vector3(randomx, randomy, 0), transform.rotation);
    }
}
