using UnityEngine;

public class MoveHorizontal2D : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 6f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw(""Horizontal"");
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
    }
}