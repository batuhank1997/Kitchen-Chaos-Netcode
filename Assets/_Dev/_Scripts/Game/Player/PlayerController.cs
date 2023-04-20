using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameInput gameInput;

    [SerializeField] private PlayerInteractions playerInteractions;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerAnimator playerAnimator;

    
    public PlayerInteractions PlayerInteractions => playerInteractions;
    public PlayerMovement PlayerMovement => playerMovement;
    public PlayerAnimator PlayerAnimator => playerAnimator;
    public GameInput GameInput => gameInput;
}
