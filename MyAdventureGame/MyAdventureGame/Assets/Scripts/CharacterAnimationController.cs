using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    //Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    //Update is called once per frame
    void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        // Hasndle running and Idling
        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        
        //Handle Jumping
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Hop");
        }
        
        // Handle Wall jumping
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }
            
        //Triggers the Double Jump Animation
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("Jump");
        }
        else
        {
            animator.SetTrigger("Idle");
        }

        //Triggers the Hit Animation
        if (Input.GetKeyDown(KeyCode.H)) // Change from GetButtonDown to GetKeyDown
        {
            animator.SetTrigger("Hit");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
        //Triggers the Hit Animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }
        else
        {
            animator.SetTrigger("Idle");
        }
    }
}