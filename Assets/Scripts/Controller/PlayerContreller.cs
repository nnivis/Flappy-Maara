using UnityEngine;
using UnityEngine.InputSystem;

namespace FlappyBird
{
    public class PlayerContreller : MonoBehaviour
    {
        [SerializeField] InputActionAsset _inputActionAssets;
        InputAction _jumpAction;
        JumpComponent _jumpComponent;

        void Awake()
        {
            _jumpAction = _inputActionAssets.FindAction("Jump");
        }
        void Start()
        {
            _jumpComponent = GetComponent<JumpComponent>();
        }

        void OnEnable()
        {
            _inputActionAssets.FindActionMap("PlayerInput").Enable();
        }

        void OnDisable()
        {
            _inputActionAssets.FindActionMap("PlayerInput").Disable();
        }


        void Update()
        {
            if (_jumpAction.WasPerformedThisFrame())
            {
                _jumpComponent.Jump();
            }
        }
    }
}