using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private Animator animator;

    private void Start()
    {
        animator.SetBool(Keys.ANIM_IS_WALKING, false);
    }

    private void Update()
    {
        animator.SetBool(Keys.ANIM_IS_WALKING, playerController.PlayerMovement.IsWalking);
    }
}
