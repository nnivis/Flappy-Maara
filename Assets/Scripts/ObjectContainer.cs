using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class ObjectContainer : MonoBehaviour
    {
        List<GameObject> _targetObjects = new List<GameObject>();

        public void AddTargetObject(GameObject obj)
        {
            _targetObjects.Add(obj);
        }

        public void DeleteTargetObjects()
        {
            foreach (GameObject obj in _targetObjects)
            {
                Destroy(obj);
            }
            _targetObjects.Clear();
        }

    }
}
