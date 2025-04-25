using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public GameObject winScreen;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Make sure your player has the "Player" tag
        {
            winScreen.SetActive(true);
            Time.timeScale = 0f; // Freeze the game
            Debug.Log("You Win!");
        }
    }
}