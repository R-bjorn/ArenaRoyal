using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void CarSimu()
    {
        SceneManager.LoadScene("Scenes/Car Simulator/CarSimu");
    }

    public void PlaneSimu()
    {
        SceneManager.LoadScene("Scenes/Plane Simulator/PlaneSimu");
    }
    
    public void QuitGame()
    {
                // save any game data here
        #if UNITY_EDITOR
                // Application.Quit() does not work in the editor so
                // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                 Application.Quit();
        #endif
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            QuitGame();
        }
    }
}
