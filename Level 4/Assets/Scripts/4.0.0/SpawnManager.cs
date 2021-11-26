using System;
using _4._0._0;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;


public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    // private int animalIndex = 0;
    public TextMeshProUGUI countT;
    public GameObject winTextObject;

    private float spawnRangeX = 13;
    private float spawnRangeZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0 , spawnRangeZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        var animal = Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        DetectCollision dc = animal.GetComponent<DetectCollision>();
        dc.countText = countT;
        dc.winTextObject = winTextObject;
    }
}
