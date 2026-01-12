using UnityEngine;

public class CollectibleHeal2D : MonoBehaviour
{
    public int healAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(""Player"")) return;
        var hp = other.GetComponent<Health>();
        if (hp) hp.Heal(healAmount);
        Destroy(gameObject);
    }
}