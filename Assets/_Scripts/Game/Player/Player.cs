using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float rotationSpeed;

    public bool IsWalking { get; set; }

    private void Update()
    {
        var deltaTime = Time.deltaTime;
        
        Vector2 inputVector = Vector2.zero;
        
        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = +1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = +1;
        }

        inputVector = inputVector.normalized;

        var moveDir = new Vector3(inputVector.x, 0, inputVector.y);

        IsWalking = moveDir != Vector3.zero;
        
        transform.position += moveDir * (playerSpeed * deltaTime);
        transform.forward = Vector3.Slerp(transform.forward, moveDir, rotationSpeed * deltaTime);
    }
}
