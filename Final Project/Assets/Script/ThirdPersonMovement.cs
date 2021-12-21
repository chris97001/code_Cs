using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ThirdPersonMovement : MonoBehaviour
{
    //Object references
    [SerializeField] CharacterController controller;
    [SerializeField] Transform cam;
    [SerializeField] CinemachineFreeLook cam1;
    [SerializeField] CinemachineFreeLook cam2;
    //

    //Plane Movment Parameters
    [SerializeField] float WalkingSpeed = -2f;
    [SerializeField] float RunningSpeed = 15f;
    [SerializeField] float WallJumpSpeed = 20f;
    [SerializeField] float AirMovingSpeed = 5f;
    [SerializeField] float LerpTime = 0.1f;
    Vector3 moveDirection;
    Vector3 desMotion,curMotion;
    float MaxSpeed;
    float targetAngle;
    float angle;
    //

    //Jump/Fall Parameters
    public bool isGrabing;
    public bool isGrounded;
    [SerializeField] float downSlidingSpeed=0f;
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundDistance = 0.4f;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float gravity = -9.8f;
    [SerializeField] float jumpHeight = 3f;
    Vector3 velocity;
    //

    //Rotation Parameters
    [SerializeField] float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
    //

    //To do 
    //

    private void Start()
    {
        cam1.Priority = 1;
        cam2.Priority = 0;
    }
    // Update is called once per frame
    void Update()
    {
        Jump();
        Move();
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        hitOnWall(hit);
    }
    private void hitOnWall(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag != "Wall")
        {
            isGrabing = false;
            return;
        }

        if (hit.normal.y < 0.1f)
        {
            if (velocity.y < 0)
            {
                isGrabing = true;
                velocity.y = downSlidingSpeed;
            }
            if (Input.GetButtonDown("Jump"))
            {
                isGrabing = false;
                //switchCam();
                //Debug.DrawRay(hit.point, hit.normal, Color.blue, 1.25f);
                //transform.forward = hit.normal;
                //transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0));
                //moveDirection = Quaternion.Euler(0f, targetAngle + 180, 0f) * Vector3.forward;
                //curMotion = moveDirection.normalized * WallJumpSpeed * Time.deltaTime;
                controller.slopeLimit = 90;
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
        }


    }
    private void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        if (direction.magnitude >= 0.1f)
        {
            //Rotate
            targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            //

            if (isGrounded)
            {
                //Run
                if (Input.GetKey(KeyCode.LeftShift))
                    MaxSpeed = RunningSpeed;
                else
                    MaxSpeed = WalkingSpeed;
                //
            }
            else
            {
                //in Air
                MaxSpeed = Mathf.Lerp(MaxSpeed, AirMovingSpeed, LerpTime*0.1f);
                isGrabing = false;
                //
            }
        }
        else
        {
            MaxSpeed = 0;
            if(!isGrounded)
                isGrabing = false;
        }
        desMotion = moveDirection.normalized * MaxSpeed * Time.deltaTime;
        if (curMotion.magnitude <= desMotion.magnitude - 0.01f || curMotion.magnitude >= desMotion.magnitude + 0.01f)
            curMotion = Vector3.Lerp(curMotion, desMotion, LerpTime);
        else
            curMotion = desMotion;

        if (!isGrabing)
            controller.Move(curMotion);
        
    }
    private void Jump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            controller.slopeLimit = 45;
            velocity.y = -2f;
        }
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            controller.slopeLimit = 90;
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }
    private void switchCam()
    {
        if (!Input.GetButton("Vertical")) return;
        if (cam1.Priority == 1)
        {
            cam1.Priority = 0;
            cam2.Priority = 1;
        }
        else
        {
            cam1.Priority = 1;
            cam2.Priority = 0;
        }
    }
}
