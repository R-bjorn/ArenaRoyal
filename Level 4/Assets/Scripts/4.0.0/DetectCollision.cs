using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Food"))
        {
            Debug.Log("Collide");
            Destroy(gameObject);
            Destroy(other.gameObject);   
        }
    }
}
