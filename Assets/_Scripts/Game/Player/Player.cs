using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private GameInput gameInput;

    public bool IsWalking { get; private set; }

    private void Update()
    {
        Move();
    }

    void Move()
    {
        var deltaTime = Time.deltaTime;
        
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();

        var moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        IsWalking = moveDir != Vector3.zero;
        
        transform.position += moveDir * (playerSpeed * deltaTime);
        transform.position = Vector3.Slerp(transform.position, transform.position + moveDir * (playerSpeed * deltaTime), 0.075f);
        transform.forward = Vector3.Slerp(transform.forward, moveDir, rotationSpeed * deltaTime);
    }
}
