using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class MoveComponent : MonoBehaviour
    {
        [SerializeField] float _speed; 

        void Update()
        {
            transform.Translate(-_speed * Time.deltaTime, 0, 0); 
        }
    }
}
