using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Scenes/4.0.0");
    }

    public void Personalize()
    {
        SceneManager.LoadScene("Scenes/Personalize");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
