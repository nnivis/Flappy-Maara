using UnityEngine;

namespace FlappyBird
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] GameObject _pipeSpawnPrefab;
        [SerializeField] GameObject _playerSpawnPrefab;
        [SerializeField] GameObject _scorePrefab;
        [SerializeField] SpawnComponent _spawner;
        [SerializeField] ObjectContainer _objectContainer;

        void OnEnable()
        {
            _spawner.SetSpawnInfo(_playerSpawnPrefab, _pipeSpawnPrefab, _scorePrefab, _objectContainer);
            _spawner.StartSpawning();
        }

    }
}
