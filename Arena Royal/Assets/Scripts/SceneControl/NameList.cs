using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneControl
{
    public class NameList : MonoBehaviour
    {

        public new TextMeshProUGUI name;
        public float nameChange = 2f;

        void Start()
        {
            StartCoroutine(Magic());
        }
    
        IEnumerator Magic()
        {
            name.text = "Ravi Trivedi";
            yield return new WaitForSeconds(nameChange);
            name.text = "Maria Hutchinson";
            yield return new WaitForSeconds(nameChange);
            name.text = "Brennan Gagnier";
            yield return new WaitForSeconds(nameChange);
            SceneManager.LoadScene("Menu");
        }
    }   
}
