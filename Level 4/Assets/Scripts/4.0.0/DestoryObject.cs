using UnityEngine;

namespace _4._0._0
{
    public class DestoryObject : MonoBehaviour
    {
        public float topBound = 30;
        public float lowerBound = -10;
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
}
