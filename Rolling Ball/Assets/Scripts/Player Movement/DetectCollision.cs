using TMPro;
using UnityEngine;

namespace _4._0._0
{
    public class DetectCollision : MonoBehaviour
    {
        // public GameObject winTextObject;
        public TextMeshProUGUI countText;
        private int count = 0;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.tag.Equals("Food"))
            {
                SetCountText();
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
        
        void SetCountText()
        {
            countText.text = "Count : {++count} / 10";

            if (count >= 10)
            {
                // winTextObject.SetActive(true);
            }
        }
    }
}
