using UnityEngine;

public class MoveRigidbody3D : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw(""Horizontal"");
        float z = Input.GetAxisRaw(""Vertical"");
        Vector3 v = new Vector3(x, 0f, z).normalized * speed;
        rb.velocity = new Vector3(v.x, rb.velocity.y, v.z);
    }
}