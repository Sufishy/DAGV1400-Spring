using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.81f;
    
    private CharacterController controller;
    private Vector3 velocity;
    private Transform thisTransform;
    
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
    }

    private void MoveCharacter()
    {
       float moveInput = Input.GetAxis("Horizontal"); // fixed by making it float?
       Vector3 move = new Vector3(moveInput * moveSpeed, 0f, 0f) * Time.deltaTime; // Fixed?
       controller.Move(move);
        
        //Jumping
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
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