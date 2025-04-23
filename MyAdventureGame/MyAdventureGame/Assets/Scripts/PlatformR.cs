using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformR : MonoBehaviour
{
    public float moveDistance = 5f;
    public float moveSpeed = 2f;

    private Vector3 targetPosition;
    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                isMoving = false;
            }
        }
    }

    public void MovePlatformRight()
    {
        if (!isMoving)
        {
            targetPosition = transform.position + Vector3.right * moveDistance;
            isMoving = true;
        }
    }
}