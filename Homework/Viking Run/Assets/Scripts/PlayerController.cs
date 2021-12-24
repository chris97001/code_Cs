using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //camera ref
    public Camera cam;
    Vector3 camOffset;
    public Vector3 camOffset_Dead;
    public Vector3 camOffset_Play;
    Vector3 camRotation;
    public Vector3 camRotation_Dead;
    public Vector3 camRotation_Play;
    //Status
    int Timer;
    public int CoinCount;
    public bool isDead;
    //Move
    public float forwardSpeed = 10f;
    public float forwardAcceleration = 0.05f;
    public float horizontalSpeed = 7.5f;
    public CharacterController controller;
    //Rotation
    float targetAngle;
    float PlayerAngle;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    //Jump
    public bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    Vector3 velocity;
    bool canDoubleJump;
    //Caught
    public MonsterController monsterController;

    private void Start()
    {
        Timer = 0;
        CoinCount = 0;
        isDead = false;
        camOffset = camOffset_Dead;
        camRotation = camRotation_Dead;
    }


    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            Move();
            Turn();
            Jump();
            GameStartCameraMove();
            if (transform.position.y < -15f) PlayerFall();
        }
        else
        {
            GameoverCameraMove();
        }
    }
    private void Move()
    {
        forwardSpeed += forwardAcceleration;
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector3 forwardMove = transform.forward * forwardSpeed * Time.deltaTime;
        Vector3 horizontalMove = transform.right * horizontal * horizontalSpeed * Time.deltaTime;
        controller.Move(forwardMove + horizontalMove);
    }
    private void Turn()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            targetAngle -= 90;
            if (targetAngle < 0) targetAngle += 360;
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            targetAngle += 90;
            if (targetAngle > 360) targetAngle -= 360;
        }

        PlayerAngle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, PlayerAngle, 0f);
    }
    private void Jump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            //controller.slopeLimit = 45;
            velocity.y = -2f;
            canDoubleJump = true;
        }
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            //controller.slopeLimit = 90;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        if(Input.GetButtonDown("Jump") && !isGrounded && canDoubleJump)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            canDoubleJump = false;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Obstacle" && controller.velocity.magnitude == 0) 
        {
            PlayerCaught();
        }
    }
    private void GameoverCameraMove()
    {
        camOffset=Vector3.Lerp(camOffset, camOffset_Dead, 0.01f);
        cam.transform.localPosition = camOffset;
        camRotation = Vector3.Lerp(camRotation, camRotation_Dead, 0.01f);
        cam.transform.localEulerAngles = camRotation;
    }
    private void GameStartCameraMove()
    {
        camOffset=Vector3.Lerp(camOffset, camOffset_Play, 0.01f);
        cam.transform.localPosition = camOffset;
        camRotation = Vector3.Lerp(camRotation, camRotation_Play, 0.01f);
        cam.transform.localEulerAngles = camRotation;
    }
    private void PlayerCaught()
    {
        isDead = true;
        monsterController.catchPlayer();
    }
    private void PlayerFall()
    {
        isDead = true;
        monsterController.PlayerFall();
    }
}
