using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 10;

    private float verticalInput;
    private float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward  * speed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }
    }
    
    public void QuitGame()
    {
                // save any game data here
        #if UNITY_EDITOR
                // Application.Quit() does not work in the editor so
                // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                         SceneManager.LoadScene("Scenes/Menu/Menu");
        #endif
    }
}
