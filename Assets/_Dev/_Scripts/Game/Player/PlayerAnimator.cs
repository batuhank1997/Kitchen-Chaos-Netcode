using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerAnimator : NetworkBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Animator animator;

    private void Start()
    {
        animator.SetBool(Keys.ANIM_IS_WALKING, false);
    }

    private void Update()
    {
        if (!IsOwner) return;

        animator.SetBool(Keys.ANIM_IS_WALKING, playerController.PlayerMovement.IsWalking);
    }
}
