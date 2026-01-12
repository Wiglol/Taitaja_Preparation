using UnityEngine;

public class BreakableObject2D : MonoBehaviour
{
    public Health health;
    public GameObject breakVfxPrefab;

    private void Awake()
    {
        if (!health) health = GetComponent<Health>();
        if (health) health.onDeath += Break;
    }

    private void Break()
    {
        if (breakVfxPrefab)
            Instantiate(breakVfxPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}