using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestoryObject : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
            Destroy(gameObject);
        if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            // SceneManager.LoadScene("Scene/GameOver");
        }
    }
}
