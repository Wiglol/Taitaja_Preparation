using UnityEngine;

public class EnemyShootWhenInRange2D : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float interval = 1f;
    public float detectionRadius = 8f;

    private Transform player;
    private float t;

    private void Start()
    {
        var p = GameObject.FindGameObjectWithTag(""Player"");
        if (p) player = p.transform;
    }

    private void Update()
    {
        if (!player || !projectilePrefab || !firePoint) return;

        if (Vector2.Distance(transform.position, player.position) > detectionRadius) return;

        t += Time.deltaTime;
        if (t >= interval)
        {
            Vector2 dir = (player.position - firePoint.position).normalized;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            firePoint.rotation = Quaternion.Euler(0f, 0f, angle);

            Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
            t = 0f;
        }
    }
}