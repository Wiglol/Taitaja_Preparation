using UnityEngine;

public class PlayerKnockbackReceiver : MonoBehaviour
{
    public Rigidbody2D rb;
    public float force = 6f;

    private void Awake()
    {
        if (!rb) rb = GetComponent<Rigidbody2D>();
    }

    public void Apply(Vector2 fromPosition)
    {
        if (!rb) return;

        Vector2 dir = ((Vector2)transform.position - fromPosition).normalized;
        rb.AddForce(dir * force, ForceMode2D.Impulse);
    }
}