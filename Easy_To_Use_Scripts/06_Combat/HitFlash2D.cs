using UnityEngine;

public class HitFlash2D : MonoBehaviour
{
    public Health health;
    public SpriteRenderer sr;
    public float flashTime = 0.08f;

    private float t;
    private Color original;

    private void Awake()
    {
        if (!health) health = GetComponent<Health>();
        if (!sr) sr = GetComponentInChildren<SpriteRenderer>();
        if (sr) original = sr.color;
    }

    private void OnEnable()
    {
        if (health != null) health.onDamaged += OnDamaged;
    }

    private void OnDisable()
    {
        if (health != null) health.onDamaged -= OnDamaged;
    }

    private void OnDamaged(int _)
    {
        t = flashTime;
        if (sr) sr.color = Color.white;
    }

    private void Update()
    {
        if (t <= 0f) return;
        t -= Time.deltaTime;
        if (t <= 0f && sr) sr.color = original;
    }
}