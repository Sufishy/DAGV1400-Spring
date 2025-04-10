using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SimpleNavMeshAgent : MonoBehaviour
{
    public Transform target; // assign target point in the inspector window
    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false; // this disables automatic rotation for 2d
    }

    private void Update()
    {
        if (target != null)
        {
            agent.SetDestination(target.position);
        }
    }
}