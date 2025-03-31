using UnityEngine;
using UnityEngine.Events;

public class SimpleIDMatchBehaviour : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>(); // Get Animator from Fire Object
    }

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<SimpleIDBehaviour>();

        if (otherID != null && otherID.id == id)
        {
            Debug.Log("Matched ID: " + id);
            matchEvent.Invoke();
            
            // Play the "Deactivate" animation
            if (animator != null)
            {
                animator.SetTrigger("Deactivate");
            }
        }
        else
        {
            Debug.Log("No Match: " + id);
            noMatchEvent.Invoke();
        }
    }
}