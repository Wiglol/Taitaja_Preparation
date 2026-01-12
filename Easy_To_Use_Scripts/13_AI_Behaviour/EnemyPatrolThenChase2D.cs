using UnityEngine;

public class EnemyPatrolThenChase2D : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float patrolSpeed = 2f;

    public float chaseSpeed = 2.8f;
    public float chaseRadius = 6f;

    private Transform player;
    private Transform target;

    private void Start()
    {
        var p = GameObject.FindGameObjectWithTag(""Player"");
        if (p) player = p.transform;

        target = pointB;
    }

    private void Update()
    {
        if (!pointA || !pointB) return;

        bool shouldChase = player && (Vector2.Distance(transform.position, player.position) <= chaseRadius);

        if (shouldChase)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, chaseSpeed * Time.deltaTime);
            FaceX(player.position.x);
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, patrolSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.05f)
        {
            target = (target == pointA) ? pointB : pointA;
            FaceX(target.position.x);
        }
    }

    private void FaceX(float xTarget)
    {
        Vector3 s = transform.localScale;
        s.x = (xTarget >= transform.position.x) ? Mathf.Abs(s.x) : -Mathf.Abs(s.x);
        transform.localScale = s;
    }
}