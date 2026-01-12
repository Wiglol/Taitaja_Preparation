using UnityEngine;

public class Projectile2D : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 3f;
    public int damage = 1;
    public string hitTag = ""Enemy"";

    private float t;

    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;

        t += Time.deltaTime;
        if (t >= lifeTime) Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!string.IsNullOrEmpty(hitTag) && !other.CompareTag(hitTag)) return;
        var d = other.GetComponent<IDamageable>();
        if (d != null) d.TakeDamage(damage);
        Destroy(gameObject);
    }
}