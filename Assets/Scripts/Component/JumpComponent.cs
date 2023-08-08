using UnityEngine;

namespace FlappyBird
{
    public class JumpComponent : MonoBehaviour
    {

        [SerializeField] float _force;
        [SerializeField] Rigidbody2D _rigidBody2D;

        void Start()
        {
            _rigidBody2D = GetComponent<Rigidbody2D>();
        }
        public void Jump()
        {
            _rigidBody2D.velocity = Vector2.up * _force;
        }
    }
}
