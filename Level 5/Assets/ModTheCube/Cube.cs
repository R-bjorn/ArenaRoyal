using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float smoothRotation = 0.5f;
    public GameObject Dice;
    
    // Script Control
    public bool changeColor = true;

    Renderer Renderer;
    private Vector3 _endPos = new Vector3( 30, 15, 45);
    void Start()
    {
        Renderer = Dice.GetComponent<Renderer>();
        // transform.position = new Vector3(5, 10, 0);
        transform.localScale = Vector3.one * 2.3f;
        if (changeColor)
            InvokeRepeating("ChangeeColor", 4.0f, 1.5f);
    }

    void ChangeeColor()
    {
        Material material = Renderer.material;

        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f),
            Random.Range(0.2f, 1.0f));
    }

    void Update()
    {
        transform.Rotate(_endPos * Time.deltaTime * smoothRotation);
        _endPos += new Vector3(_endPos.x + 30, _endPos.y + 15, _endPos.z + 45);
        
        if (_endPos.x > 360f)
        {
            _endPos.x = 0;
            _endPos.y = 0;
            _endPos.z = 0;
        }
    }
}