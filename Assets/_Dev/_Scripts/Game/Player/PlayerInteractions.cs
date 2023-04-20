using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    
    public Action<ClearCounter> OnSelectedCounterChanged;
    
    private Vector3 lastInteractDir;
    private ClearCounter selectedCounter;
    
    private void Start()
    {
        playerController.GameInput.OnInteractAction += OnInteractAction;
    }

    private void OnInteractAction()
    {
        if (!selectedCounter) return;
        
        Vector2 inputVector = playerController.GameInput.GetMovementVectorNormalized();

        var moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        if (moveDir != Vector3.zero)
        {
            lastInteractDir = moveDir;
        }

        var interactDistance = 2f;

        if (Physics.Raycast(transform.position, lastInteractDir, out RaycastHit hitInfo, interactDistance)) 
        {
            if (hitInfo.transform.TryGetComponent(out ClearCounter clearCounter))
            {
                clearCounter.Interact();
            }
        }
    }

    void Update()
    {
        HandleInteractions();
    }
    
    void HandleInteractions()
    {
        Vector2 inputVector = playerController.GameInput.GetMovementVectorNormalized();

        var moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        if (moveDir != Vector3.zero)
        {
            lastInteractDir = moveDir;
        }

        var interactDistance = 2f;

        if (Physics.Raycast(transform.position, lastInteractDir, out RaycastHit hitInfo, interactDistance)) 
        {
            if (hitInfo.transform.TryGetComponent(out ClearCounter clearCounter))
            {
                if (clearCounter != selectedCounter)
                    SetSelectedCounter(clearCounter);
                
            }
            else
            {
                SetSelectedCounter(null);
            }
        }
        else
            SetSelectedCounter(null);
    }

    void SetSelectedCounter(ClearCounter clearCounter)
    {
        selectedCounter = clearCounter;
        OnSelectedCounterChanged?.Invoke(selectedCounter);
    }
}
