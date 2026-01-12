using UnityEngine;

public class DamageWithIFrames2D : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(""Player"")) return;

        var i = other.GetComponent<InvincibilityFrames>();
        if (i && !i.CanTakeHit()) return;

        var d = other.GetComponent<IDamageable>();
        if (d != null) d.TakeDamage(damage);

        if (i) i.Trigger();
    }
}