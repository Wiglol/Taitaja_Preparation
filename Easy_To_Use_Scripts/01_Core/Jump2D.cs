using UnityEngine;

public class Jump2D : MonoBehaviour
{
    public float jumpForce = 8f;

    private Rigidbody2D rb;
    private bool grounded;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
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