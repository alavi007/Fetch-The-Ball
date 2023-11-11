using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnRangeX = 17;
    private float spawnPosY = 23;

    private float startDelay = 1;
    private float spawnInterval = 4;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    void SpawnRandomBall()
    {
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(ballPrefabs[ballIndex], spawnPos, Quaternion.Euler(rotation));

    }
}
