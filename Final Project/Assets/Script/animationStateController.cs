using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class animationStateController : MonoBehaviour
{
    [SerializeField] Transform CharacterPosition;
    [SerializeField] ThirdPersonMovement player;
    Vector3 LastPosition;
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int isJumpingHash;
    int isGrabingHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isJumpingHash = Animator.StringToHash("isJumping");
        isGrabingHash = Animator.StringToHash("isGrabing");
        LastPosition = CharacterPosition.position;
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);
        bool isJumping = animator.GetBool(isJumpingHash);
        bool isGrabing = animator.GetBool(isGrabingHash);
        bool movePressed = Input.GetButton("Horizontal") | Input.GetButton("Vertical");
        bool jumpPressed = Input.GetButton("Jump");
        bool runPressed = Input.GetKey(KeyCode.LeftShift);
        //jump
        //if(jumpPressed && player.isGrounded)
        //    animator.SetBool(isJumpingHash, true);
        //else if(isJumping && player.isGrounded)
        //    animator.SetBool(isJumpingHash, false);
        animator.SetBool(isJumpingHash, !player.isGrounded);
        //move
        if (movePressed)
        {
            animator.SetBool(isWalkingHash, true);
            if (runPressed)
                animator.SetBool(isRunningHash, true);
            else
                animator.SetBool(isRunningHash, false);
        }
        if(!movePressed||CharacterPosition.position.magnitude == LastPosition.magnitude)
        {
            animator.SetBool(isWalkingHash, false);
            animator.SetBool(isRunningHash, false);
        }
        animator.SetBool(isGrabingHash, player.isGrabing);
        //Debug.Log(CharacterPosition.position.magnitude.ToString()+"  "+LastPosition.magnitude.ToString());
        LastPosition = CharacterPosition.position;
    }
}
