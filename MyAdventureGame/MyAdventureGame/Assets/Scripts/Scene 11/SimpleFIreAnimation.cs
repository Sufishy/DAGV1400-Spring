using UnityEngine;

public class FireAnimationController : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D damageCollider;

    void Start()
    {
        animator = GetComponent<Animator>();
        damageCollider = GetComponent<BoxCollider2D>();

        // ✅ Ensure Fire starts active
        animator.Play("FireActive");
        damageCollider.enabled = true;
    }

    public void DeactivateFire()
    {
        animator.SetTrigger("StopFire"); // Transitions to FireDeactivate animation
        damageCollider.enabled = false; // Disable damage when fire stops
    }
}