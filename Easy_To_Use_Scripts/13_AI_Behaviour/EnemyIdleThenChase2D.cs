using UnityEngine;

public class EnemyIdleThenChase2D : MonoBehaviour
{
    public float idleSeconds = 1.5f;
    public float speed = 2.5f;
    public float chaseRadius = 6f;

    private Transform player;
    private float idleLeft;

    private void Start()
    {
        var p = GameObject.FindGameObjectWithTag(""Player"");
        if (p) player = p.transform;

        idleLeft = idleSeconds;
    }

    private void Update()
    {
        if (!player) return;

        float d = Vector2.Distance(transform.position, player.position);
        if (d > chaseRadius) return;

        if (idleLeft > 0f)
        {
            idleLeft -= Time.deltaTime;
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);

        // face movement direction (simple)
        Vector3 s = transform.localScale;
        s.x = (player.position.x >= transform.position.x) ? Mathf.Abs(s.x) : -Mathf.Abs(s.x);
        transform.localScale = s;
    }
}