using UnityEngine;

public class EnemyTurnAtEdge2D : MonoBehaviour
{
    [Header(""Movement"")]
    public float speed = 2f;
    public int direction = 1;

    [Header(""Edge Check"")]
    public Transform edgeCheck;
    public float edgeCheckDistance = 0.8f;
    public LayerMask groundLayer;

    private void Update()
    {
        transform.position += Vector3.right * (direction * speed * Time.deltaTime);

        if (!edgeCheck) return;

        bool groundAhead = Physics2D.Raycast(edgeCheck.position, Vector2.down, edgeCheckDistance, groundLayer);
        if (!groundAhead)
            Flip();
    }

    private void Flip()
    {
        direction *= -1;

        Vector3 s = transform.localScale;
        s.x *= -1f;
        transform.localScale = s;
    }

    private void OnDrawGizmosSelected()
    {
        if (!edgeCheck) return;
        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(edgeCheck.position, edgeCheck.position + Vector3.down * edgeCheckDistance);
    }
}