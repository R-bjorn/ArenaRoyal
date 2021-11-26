using UnityEngine;
using UnityEngine.SceneManagement;

namespace _4._0._0.UI.Personalize
{
    public class Personalize : MonoBehaviour
    {

        public Renderer groundPrefab;
        public Renderer ground;
        public Material concrete;
        public Material grass;
        public Material gravel;
        public Material sand;

        // public Material currentMaterial;

        // private void Start()
        // {
        //     currentMaterial = ground.GetComponent<Material>();
        // }

        public void ApplyConcrete()
        {
            Debug.Log(groundPrefab.sharedMaterial);
            ground.sharedMaterial = concrete;
            groundPrefab.sharedMaterial = concrete;
            Debug.Log(groundPrefab.sharedMaterial);
        }

        public void ApplyGrass()
        {
            Debug.Log(groundPrefab.sharedMaterial);
            ground.sharedMaterial = grass;
            groundPrefab.sharedMaterial = grass;
            Debug.Log(groundPrefab.sharedMaterial);
        }

        public void ApplyGravel()
        {
            Debug.Log(groundPrefab.sharedMaterial);
            ground.sharedMaterial = gravel;
            groundPrefab.sharedMaterial = gravel;
            Debug.Log(groundPrefab.sharedMaterial);
        }

        public void ApplySand()
        {
            Debug.Log(groundPrefab.sharedMaterial);
            ground.sharedMaterial = sand;
            groundPrefab.sharedMaterial = sand;
            Debug.Log(groundPrefab.sharedMaterial);
        }

        public void Back()
        {
            SceneManager.LoadScene("Scenes/Menu");
        }
    }
}
