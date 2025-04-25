using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1f; // Unpause the game!
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}