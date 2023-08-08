using UnityEngine;
using System;

namespace FlappyBird
{
    public class PlayerInteractionComponent : MonoBehaviour
    {
        public event Action<GameObject> OnInteract;
        void Start()
        {
            GameManager.Instance.RegisterPlayerInteractionComponent(this);
        }

        void OnDestroy()
        {
            GameManager.Instance.UnregisterPlayerInteractionComponent(this);
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Pipe"))
            {
                Destroy(gameObject);
            }
            else if (other.gameObject.CompareTag("Score"))
            {
                Destroy(other.gameObject);
            }

            OnInteract?.Invoke(other.gameObject);
        }

    }
}
