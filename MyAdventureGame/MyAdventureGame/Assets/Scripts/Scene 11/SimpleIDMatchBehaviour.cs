using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehaviour : MonoBehaviour
{
    public Id id; // Fire hazard's ID
    public UnityEvent matchEvent, noMatchEvent; // Define events in the inspector
    
    public Animator fireAnimator; // Reference to fire hazard's animator
    public BoxCollider fireCollider; // Reference to fire hazard's collider

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIDBehaviour>();

        if (otherID != null && otherID.id == id) // Check if watermelon is touching the fire hazard
        {
            matchEvent.Invoke();
            Debug.Log("Matched ID: " + id);

            // Stop fireActive animation and start FireDeactivate
            fireAnimator.SetBool("fireActive", false);
            fireAnimator.SetBool("fireDeactivate", true);

            // Disable the fire hazard's collider
            fireCollider.enabled = false;
        }
        else
        {
            noMatchEvent.Invoke();
            Debug.Log("No Match or no ID: " + id);
        }
    }
}