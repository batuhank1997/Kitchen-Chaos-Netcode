using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameInput : Singleton<GameInput>
{
    private PlayerInputActions playerInputActions;
    public static Action OnInteractAction;
    public static Action OnShootAction;
    
    private void Awake()
    {
        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        
        playerInputActions.Player.Interact.performed += InteractOnPerformed;
        playerInputActions.Player.Shoot.performed += InteractOnPerformedShoot;
    }

    private void InteractOnPerformed(InputAction.CallbackContext obj)
    {
        OnInteractAction?.Invoke();
    }
    
    private void InteractOnPerformedShoot(InputAction.CallbackContext obj)
    {
        OnShootAction?.Invoke();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputActions.Player.Move.ReadValue<Vector2>();

        return inputVector.normalized;
    }
}
