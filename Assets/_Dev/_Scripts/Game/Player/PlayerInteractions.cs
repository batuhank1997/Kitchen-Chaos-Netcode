using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    private Vector3 lastInteractDir;
    
    private void Start()
    {
        playerController.GameInput.OnInteractAction += OnInteractAction;
    }

    private void OnInteractAction()
    {
        Vector2 inputVector = playerController.GameInput.GetMovementVectorNormalized();

        var moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        if (moveDir != Vector3.zero)
            lastInteractDir = moveDir;

        var interactDistance = 2f;

        if (Physics.Raycast(transform.position, lastInteractDir, out RaycastHit hitInfo, interactDistance)) 
        {
            Debug.Log(hitInfo.collider.name);
        }
    }
}
