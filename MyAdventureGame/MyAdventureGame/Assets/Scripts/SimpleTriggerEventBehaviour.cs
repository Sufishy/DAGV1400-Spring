using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    public int damageAmount = 10; // How much damage is dealt
    public int scoreIncreaseAmount = 1;
  //  public Vector3 shrinkScale = new Vector3(0.5f, 0.5f, 0.5f); // The scale to shrink to

    private void OnTriggerEnter(Collider other)
    {
        // This triggers the event
        triggerEvent.Invoke();

        // Shrink the saw on collision
      //  transform.localScale = shrinkScale;

        Animator animator = other.GetComponent<Animator>();

        if (animator != null)
        {
            animator.SetTrigger("Hit"); // Trigger hit animation
        }

        // Apply damage
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
        }
    }
}