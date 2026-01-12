using UnityEngine;

public class HazardDamage2D : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(""Player"")) return;

        var d = other.GetComponent<IDamageable>();
        if (d != null) d.TakeDamage(damage);
    }
}