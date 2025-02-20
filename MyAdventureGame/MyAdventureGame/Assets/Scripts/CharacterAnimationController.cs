using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
    public float doubleTapTime = 1f; // Max time between taps for double jump
    private float elapsedTime;
    private int pressCount;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleAnimations();
        HandleJumpInput();
    }

    private void HandleAnimations()
    {
        // Handle running and idling
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        // Handle Jumping - removed redundant jump logic, now handled in HandleJumpInput()
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Hop");
        }

        // Handle Wall Jumping
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }

        // Triggers the Double Jump Animation - removed, now handled in HandleJumpInput()

        // Triggers the Hit Animation
        if (Input.GetKeyDown(KeyCode.H)) // Change from GetButtonDown to GetKeyDown
        {
            animator.SetTrigger("Hit");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        // Triggers the Fall Animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }

    private void HandleJumpInput()
    {
        // Count the number of times space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pressCount++;

            if (pressCount == 1)
            {
                animator.SetTrigger("Hop"); // First jump
            }
            else if (pressCount == 2 && elapsedTime <= doubleTapTime)
            {
                animator.SetTrigger("Jump"); // Double jump
                resetPressTimer();
            }
        }

        // If at least one press happened, start timing
        if (pressCount > 0)
        {
            elapsedTime += Time.deltaTime;

            // Reset if time limit exceeded
            if (elapsedTime > doubleTapTime)
            {
                resetPressTimer();
            }
        }
    }

    // Reset the press count & timer
    private void resetPressTimer()
    {
        pressCount = 0;
        elapsedTime = 0;
    }
}