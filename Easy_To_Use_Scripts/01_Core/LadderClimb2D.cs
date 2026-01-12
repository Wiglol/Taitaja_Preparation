using UnityEngine;

public class LadderClimb2D : MonoBehaviour
{
    public float climbSpeed = 4f;

    private Rigidbody2D rb;
    private bool onLadder;
    private float defaultGravity;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        defaultGravity = rb.gravityScale;
    }

    private void Update()
    {
        if (!onLadder) return;

        float y = Input.GetAxisRaw(""Vertical"");
        rb.velocity = new Vector2(rb.velocity.x, y * climbSpeed);

        if (Mathf.Abs(y) < 0.01f)
            rb.velocity = new Vector2(rb.velocity.x, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(""Ladder"")) return;

        onLadder = true;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(rb.velocity.x, 0f);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag(""Ladder"")) return;

        onLadder = false;
        rb.gravityScale = defaultGravity;
    }
}