using UnityEngine;

public class PlayerAnimationController2D : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public bool grounded;

    // Animator parameters (recommended):
    // float Speed
    // bool Grounded

    private void Awake()
    {
        if (!animator) animator = GetComponentInChildren<Animator>();
        if (!rb) rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!animator || !rb) return;

        animator.SetFloat(""Speed"", Mathf.Abs(rb.velocity.x));
        animator.SetBool(""Grounded"", grounded);
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag(""Ground"")) grounded = true;
    }

    private void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.CompareTag(""Ground"")) grounded = false;
    }
}