using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public CharacterController controller;
    public PlayerController playerController;
    Animator animator;
    int isRunningHash;
    int isJumpingHash;
    int isDeadHash;
    private void Start()
    {
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");
        isDeadHash = Animator.StringToHash("isDead");
    }
    // Update is called once per frame
    void Update()
    {
        animator.SetBool(isRunningHash, true);
        animator.SetBool(isJumpingHash, !playerController.isGrounded);
        animator.SetBool(isDeadHash, playerController.isDead);
    }
}
