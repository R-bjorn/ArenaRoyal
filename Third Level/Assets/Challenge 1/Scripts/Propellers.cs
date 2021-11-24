using UnityEngine;

namespace Challenge_1.Scripts
{
    public class Propellers : MonoBehaviour
    {

        public float speed;
        // Update is called once per frame
        void LateUpdate()
        {
            transform.Rotate(new Vector3(0, 0, 90) * Time.deltaTime * speed);
            var transformRotation = transform.rotation;
            // if (transformRotation.z > 360)
            //     transformRotation.z = 0f;
        }
    }
}
