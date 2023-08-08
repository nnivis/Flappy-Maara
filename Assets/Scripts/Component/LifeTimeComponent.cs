using UnityEngine;

namespace FlappyBird
{
    public class LifeTimeComponent : MonoBehaviour
    {
        [SerializeField] float _delay;
        float _startTime;

        void Start()
        {
            _startTime = Time.time;
        }

        void Update()
        {
            if (Time.time > _startTime + _delay)
            {
                Destroy(gameObject);
            }
        }


    }
}
