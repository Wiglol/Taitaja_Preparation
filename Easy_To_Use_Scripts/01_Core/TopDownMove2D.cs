using UnityEngine;

public class TopDownMove2D : MonoBehaviour
{
    public float speed = 6f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0f;
    }

    private void Update()
    {
        float x = Input.GetAxisRaw(""Horizontal"");
        float y = Input.GetAxisRaw(""Vertical"");
        Vector2 v = new Vector2(x, y).normalized * speed;
        rb.velocity = v;
    }
}