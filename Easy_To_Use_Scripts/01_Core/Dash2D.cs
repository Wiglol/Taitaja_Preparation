using UnityEngine;

public class Dash2D : MonoBehaviour
{
    public float dashSpeed = 16f;
    public float dashTime = 0.15f;
    public float cooldown = 0.5f;

    private Rigidbody2D rb;
    private float dashLeft;
    private float cdLeft;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        cdLeft -= Time.deltaTime;

        if (dashLeft > 0f)
        {
            dashLeft -= Time.deltaTime;
            return;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift) && cdLeft <= 0f)
        {
            float dir = Mathf.Sign(Input.GetAxisRaw(""Horizontal""));
            if (dir == 0f) dir = transform.localScale.x >= 0 ? 1f : -1f;

            rb.velocity = new Vector2(dir * dashSpeed, rb.velocity.y);
            dashLeft = dashTime;
            cdLeft = cooldown;
        }
    }
}