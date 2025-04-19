using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrawberryAnimationController : MonoBehaviour
{
    private Animator animator;
    private bool isCollected = false;

    
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    
    void Update()
    {
        HandleCollection();
    }

    private void HandleCollection()
    {
        if (isCollected)
        {
            animator.SetTrigger("Collected"); // Play collection animation
        }
    }

    private void OnTriggerEnter(Collider other) // Changed to 3D version
    {
        if (!isCollected && other.CompareTag("Player"))
        {
            isCollected = true;
            animator.SetTrigger("Collected"); // Play collection animation
            //StartCoroutine(DestroyAfterAnimation());
        }
    }

   // private IEnumerator DestroyAfterAnimation()
   // {
    //   yield return new WaitForSeconds(0.5f); // Wait for animation duration
    //    Destroy(gameObject);
   // }
}