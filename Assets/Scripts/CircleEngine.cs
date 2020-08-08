using UnityEngine;

namespace Sweet_And_Salty_Studios
{
    public class CircleEngine : MonoBehaviour
    {
        private Rigidbody2D rb2D;

        private void Awake()
        {
            rb2D = GetComponent<Rigidbody2D>();
        }
    }
}