using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player_Movement
{
    public class PlayerMove : MonoBehaviour
    {
        public float speed = 0;
        public TextMeshProUGUI countText;
        public GameObject winTextObject;
        
        private Rigidbody rb;
        private int count;
        
        private float moveX;
        private float moveY;
    
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
            count = 0;
            SetCountText();
            
            winTextObject.SetActive(false);
        }

        void OnMove(InputValue movementValue)
        {
            Vector2 movementVector2 = movementValue.Get<Vector2>();
            moveX = movementVector2.x;
            moveY = movementVector2.y;
        }

        private void FixedUpdate()
        {
            Vector3 movements = new Vector3(moveX, 0.0f, moveY);
            rb.AddForce(movements * speed);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.tag.Equals("PickUp"))
            {
                other.gameObject.SetActive(false);
                count++;
                SetCountText ();
            }
                
        }
        
        void SetCountText()
        {
            countText.text = "Count: " + count.ToString();

            if (count >= 12) 
            {
                // Set the text value of your 'winText'
                winTextObject.SetActive(true);
            }
        }
    }
}
