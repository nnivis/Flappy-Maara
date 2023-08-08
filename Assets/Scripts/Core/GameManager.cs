using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FlappyBird
{
    public class GameManager : MonoBehaviour
    {
        static GameManager instance;
        public static GameManager Instance => instance;
        List<PlayerInteractionComponent> _playerInteractionComponents = new List<PlayerInteractionComponent>();
        UIStateManager _uiStateManager;
        ScoreController _scoreController;
        ObjectContainer _objectContainer;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

            _uiStateManager = GetComponent<UIStateManager>();
            _scoreController = GetComponent<ScoreController>();
            _objectContainer = GetComponent<ObjectContainer>();
        }

        public void RegisterPlayerInteractionComponent(PlayerInteractionComponent playerInteractComponent)
        {
            _playerInteractionComponents.Add(playerInteractComponent);
            playerInteractComponent.OnInteract += OnInteract;

        }

        public void UnregisterPlayerInteractionComponent(PlayerInteractionComponent playerInteractComponent)
        {
            _playerInteractionComponents.Remove(playerInteractComponent);
            playerInteractComponent.OnInteract -= OnInteract;
        }

        void OnInteract(GameObject gameObject)
        {
            if (gameObject.CompareTag("Pipe"))
            {
                _uiStateManager.ChangeState(UIState.MAINMENU);
                _scoreController.ResetCurrentPoints();
                _objectContainer.DeleteTargetObjects();
            }
            else if (gameObject.CompareTag("Score"))
            {
                _scoreController.ScoreUpdate();
            }
        }
    }
}
