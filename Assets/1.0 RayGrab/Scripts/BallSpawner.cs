using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public float spawnRate = 3f;
    float spawnTime;
   

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < 0)
        {
            GameObject newBall = Instantiate(ballPrefab);
            newBall.transform.position = transform.position;
            spawnTime = spawnRate;
        }

        spawnTime -= Time.deltaTime;
    }
}
