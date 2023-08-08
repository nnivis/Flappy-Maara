using System.Collections;
using UnityEngine;

namespace FlappyBird
{
    public class SpawnComponent : MonoBehaviour
    {
        GameObject _pipePrefab;
        GameObject _playerPrefab;
        GameObject _scorePrefab;
        ObjectContainer _objectContainer;

        public void SetSpawnInfo(GameObject playerPrefab, GameObject pipePrefab, GameObject scorePrefab, ObjectContainer objectContainer)
        {
            _playerPrefab = playerPrefab;
            _pipePrefab = pipePrefab;
            _scorePrefab = scorePrefab;
            _objectContainer = objectContainer;
        }

        public void StartSpawning()
        {
            StartCoroutine(SpawnPipe());
            StartCoroutine(SpawnScore());
            SpawnCharacter();
        }

        void SpawnCharacter()
        {
            var character = Instantiate(_playerPrefab, new Vector2(-6, 0), Quaternion.identity);
        }

        IEnumerator SpawnPipe()
        {
            while (true)
            {
                yield return new WaitForSeconds(2);
                float rand = Random.Range(-1f, 3f);
                var newPipe = Instantiate(_pipePrefab, new Vector2(10, rand), Quaternion.identity);
                AddContainer(newPipe);
            }
        }

        IEnumerator SpawnScore()
        {
            while (true)
            {
                yield return new WaitForSeconds(4);
                float rand = Random.Range(-1f, 5f);
                var newScore = Instantiate(_scorePrefab, new Vector2(10, rand), Quaternion.identity);
                AddContainer(newScore);
            }
        }

        void AddContainer(GameObject gameObject)
        {
            _objectContainer.AddTargetObject(gameObject);
        }
    }
}
