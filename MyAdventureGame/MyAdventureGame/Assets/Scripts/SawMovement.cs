using System.Collections;
using UnityEngine;

public class SawMovement : MonoBehaviour
{
    public float moveDistance = 2f;         // Distance to move up and down
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
            float newY = startPosition.y + Mathf.Sin(Time.time * moveSpeed) * moveDistance;
            transform.position = new Vector3(startPosition.x, newY, startPosition.z);
        }
    }

    // Call this from the UnityEvent
    public void StopMovement()
    {
        moving = false;
    }
}
