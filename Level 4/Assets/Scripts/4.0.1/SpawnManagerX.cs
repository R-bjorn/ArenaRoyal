using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    
    private float spawnInterval = 4f;

    // Start is called before the first frame update
    private void Start()
    {
        Invoke("SpawnRandomBall", spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        // Random Ball Generator
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
        
        spawnInterval = Random.Range(3f, 5f);
        Invoke("SpawnRandomBall", spawnInterval);
    }
}
