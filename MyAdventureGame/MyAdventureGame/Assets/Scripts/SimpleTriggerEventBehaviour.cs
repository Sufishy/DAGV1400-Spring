using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;
    public int damageAmount = 10; //How much damage is dealt

    private void OnTriggerEnter(Collider other)
    {
        // this triggers the event
        triggerEvent.Invoke();
        Debug.Log("Player Interacted With Object. Nice");

        Animator animator = other.GetComponent<Animator>();

        if (animator != null)
        {
            animator.SetTrigger("Hit"); // Trigger hit animation
            Debug.Log(other.name + " hit the spikes! Ouch.");
        }

        //Apply damage
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
            Debug.Log("Player took " + damageAmount + " damage");
        }
    }
}