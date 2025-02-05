using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forces : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // This is the collision line
    void OnCollisionEnter(Collision collision)
    {
        // next collision script
        Debug.Log("Collision detected with " + collision.gameObject.name);
        
        rb.AddForce(Vector3.right * 500);
    }
}