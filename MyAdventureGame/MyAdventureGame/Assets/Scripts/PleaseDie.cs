using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseDie : MonoBehaviour
{
    public float currentHealth = 100f;

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log("Player Died!");
        gameObject.SetActive(false); // or trigger a UI here
    }
}