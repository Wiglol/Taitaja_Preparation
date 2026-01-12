using UnityEngine;

public class DamageOnTrigger2D : MonoBehaviour
{
    public int damage = 1;
    public string targetTag = ""Player"";

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!string.IsNullOrEmpty(targetTag) && !other.CompareTag(targetTag)) return;
        var d = other.GetComponent<IDamageable>();
        if (d != null) d.TakeDamage(damage);
    }
}