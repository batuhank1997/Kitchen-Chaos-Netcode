using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Singleton<PlayerController>
{
    [SerializeField] private PlayerInteractions playerInteractions;
    [SerializeField] private PlayerMovement playerMovement;
    [SerializeField] private PlayerAnimator playerAnimator;

    
    public PlayerInteractions PlayerInteractions => playerInteractions;
    public PlayerMovement PlayerMovement => playerMovement;
    public PlayerAnimator PlayerAnimator => playerAnimator;
}
