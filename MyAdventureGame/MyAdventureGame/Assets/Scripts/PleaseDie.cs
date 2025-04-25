using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleaseDie : MonoBehaviour
{
    public float currentHealth = 100f;
    public GameObject gameOverPanel; // Assign your GameOverPanel in the Inspector

    void Start()
    {
        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(false); // Hide the panel at the start
        }
    }

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

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true); // Show the Game Over UI
        }

        Time.timeScale = 0f; // Optional: Pause the game
        gameObject.SetActive(false);    // Optional: Hide player
    }
}