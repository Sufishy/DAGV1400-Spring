using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    public PlatformR platform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platform.MovePlatformRight();
        }
    }
}