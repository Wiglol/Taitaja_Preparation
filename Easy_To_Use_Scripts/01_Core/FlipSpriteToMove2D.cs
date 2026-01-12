using UnityEngine;

public class FlipSpriteToMove2D : MonoBehaviour
{
    public Rigidbody2D rb;

    private void Awake()
    {
        if (!rb) rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!rb) return;
        if (Mathf.Abs(rb.velocity.x) < 0.05f) return;

        Vector3 s = transform.localScale;
        s.x = rb.velocity.x > 0 ? Mathf.Abs(s.x) : -Mathf.Abs(s.x);
        transform.localScale = s;
    }
}