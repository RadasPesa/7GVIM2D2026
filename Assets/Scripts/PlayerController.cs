using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private InputManager inputManager;
    private PlayerInput playerInput;
    private InputAction movementAction;
    private Vector2 moveDirection;

    void Awake()
    {
        inputManager = InputManager.instance;
        playerInput = GetComponent<PlayerInput>();
        movementAction = playerInput.actions["Movement"];
    }

    void Update()
    {
        moveDirection = movementAction.ReadValue<Vector2>();
        Debug.Log(moveDirection);
    }
}
