using UnityEngine;

public class FireAnimationController : MonoBehaviour
{
    private Animator animator;
    private BoxCollider damageCollider; // ← this is for 3D!

    void Start()
    {
        animator = GetComponent<Animator>();
        damageCollider = GetComponent<BoxCollider>();

        // Fire starts active
        animator.Play("FireActive");
        damageCollider.enabled = true;
    }

    public void DeactivateFire()
    {
        animator.SetTrigger("StopFire"); // Trigger FireDeactivate animation
        damageCollider.enabled = false;  // Disable damage collider
    }
}