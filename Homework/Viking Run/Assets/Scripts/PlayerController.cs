using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float forwardSpeed = 5f;
    public float forwardAcceleration = 0.01f;
    public float horizontalSpeed = 7.5f;
    public CharacterController controller;

    float targetAngle;
    float angle;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public bool isGrounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        Move();
        Turn();
        Jump();
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

        angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
        transform.rotation = Quaternion.Euler(0f, angle, 0f);
    }
    private void Jump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            //controller.slopeLimit = 45;
            velocity.y = -2f;
        }
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            //controller.slopeLimit = 90;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }
}
