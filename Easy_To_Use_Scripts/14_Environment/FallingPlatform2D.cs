using UnityEngine;

public class FallingPlatform2D : MonoBehaviour
{
    public float delay = 0.25f;
    public float respawnTime = 2.5f;

    private Rigidbody2D rb;
    private Vector3 startPos;
    private Quaternion startRot;
    private bool triggered;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        startRot = transform.rotation;

        if (rb)
        {
            rb.bodyType = RigidbodyType2D.Kinematic;
            rb.velocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if (triggered) return;
        if (!c.gameObject.CompareTag(""Player"")) return;

        triggered = true;
        Invoke(nameof(Drop), delay);
    }

    private void Drop()
    {
        if (rb) rb.bodyType = RigidbodyType2D.Dynamic;
        Invoke(nameof(Respawn), respawnTime);
    }

    private void Respawn()
    {
        triggered = false;

        if (rb)
        {
            rb.velocity = Vector2.zero;
            rb.angularVelocity = 0f;
            rb.bodyType = RigidbodyType2D.Kinematic;
        }

        transform.SetPositionAndRotation(startPos, startRot);
    }
}