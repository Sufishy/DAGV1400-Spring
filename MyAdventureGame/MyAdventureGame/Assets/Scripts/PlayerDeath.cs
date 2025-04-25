using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject deathUI;
    public GameObject mainCamera;
    public GameObject deathCamera;

    // This method needs to be public so Unity can access it
    public void Die()
    {
        Debug.Log("💀 Player died");

        // Show the death UI
        if (deathUI != null) deathUI.SetActive(true);

        // Switch cameras
        if (mainCamera != null) mainCamera.SetActive(false);
        if (deathCamera != null) deathCamera.SetActive(true);

        // Pause the game
        Time.timeScale = 0f;
    }
}