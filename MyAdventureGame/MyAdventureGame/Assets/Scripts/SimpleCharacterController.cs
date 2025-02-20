using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float doubleJumpMultiplier = 1.5f; // try to get the double jump in
    public float gravity = -9.81f;
    
    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;
    private int jumpCount = 0;
    
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        thisTransform = transform;
    }

    private void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOnXAxis();
        
        // Got character to move vertical by placing this string in Update
        if (Input.GetButtonDown("Jump"))
        {
            if (controller.isGrounded)
            {
                jumpCount = 1; // First jump
                velocity.y = Mathf.Sqrt(jumpForce * -0.5f * gravity);
            }
            else if (jumpCount == 1) // Double jump condition
            {
                jumpCount = 2;
                velocity.y = Mathf.Sqrt(jumpForce * doubleJumpMultiplier * -0.5f * gravity);
            }
        }

        // Reset jump count when touching the ground
        if (controller.isGrounded && velocity.y <= 0f)
        {
            jumpCount = 0;
        }
    }

    private void MoveCharacter()
    {
       float moveInput = Input.GetAxis("Horizontal"); // fixed by making it float?
       Vector3 move = new Vector3(moveInput * moveSpeed, 1f, 0f) * Time.deltaTime; // Fixed?
       controller.Move(move);
       
    }

    private void ApplyGravity()
    {
        if (!controller.isGrounded)
        {
            velocity.y += gravity * Time.deltaTime;
        }
        else if (velocity.y < 0f)
        {
            velocity.y = 0f; // Reset velocity when touching ground
        }

        // Apply vertical movement
        controller.Move(velocity * Time.deltaTime);
    }
    
    private void KeepCharacterOnXAxis()
    {
        Vector3 currentPosition = thisTransform.position;
        currentPosition.z = 0f;
        thisTransform.position = currentPosition;
    }
}