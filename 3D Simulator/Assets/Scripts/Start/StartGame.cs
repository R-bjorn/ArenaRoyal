using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public TextMeshProUGUI start;
    public float countDown = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountDown());
    }
    
    IEnumerator CountDown()
    {
        start.text = "3";
        yield return new WaitForSeconds(countDown);
        start.text = "2";
        yield return new WaitForSeconds(countDown);
        start.text = "1";
        yield return new WaitForSeconds(countDown);
        start.text = "Start!";
        SceneManager.LoadScene("Prototype 1");
    }
}
