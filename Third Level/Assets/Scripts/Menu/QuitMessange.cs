using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMessange : MonoBehaviour
{
    [SerializeField] private float blinkingSpeed = 10;
    private bool flip = true;
    // Update is called once per frame
    void LateUpdate()
    {
        transform.localScale += ((flip) ? Vector3.up: Vector3.down) * Time.deltaTime * blinkingSpeed;
        flip = !flip;
    }
}
