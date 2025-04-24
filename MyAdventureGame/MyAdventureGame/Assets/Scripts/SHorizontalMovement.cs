using System.Collections;
using UnityEngine;

public class SHorizontalMovement : MonoBehaviour
{
    public float moveDistance = 2f;         // Distance to move left and right
    public float moveSpeed = 2f;            // Speed of movement
    private Vector3 startPosition;
    private bool moving = true;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (moving)
        {
            float newX = startPosition.x + Mathf.Sin(Time.time * moveSpeed) * moveDistance;
            transform.position = new Vector3(newX, startPosition.y, startPosition.z);
        }
    }

    // Call this from the UnityEvent
    public void StopMovement()
    {
        moving = false;
    }
}