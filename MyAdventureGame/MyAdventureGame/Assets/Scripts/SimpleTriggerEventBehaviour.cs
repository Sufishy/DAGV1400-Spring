using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    public int damageAmount = 10; //How much damage is dealt
    public int scoreIncreaseAmount = 1;

    private void OnTriggerEnter(Collider other)
    {
        // this triggers the event
        triggerEvent.Invoke();

        Animator animator = other.GetComponent<Animator>();

        if (animator != null)
        {
            animator.SetTrigger("Hit"); // Trigger hit animation
        }

        //Apply damage
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
            Debug.Log("Player hit the spikes, and took " + damageAmount + " damage. Ouch.");
        }
    }
}