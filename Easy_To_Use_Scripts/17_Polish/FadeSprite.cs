using UnityEngine;

public class FadeSprite : MonoBehaviour
{
    public SpriteRenderer sr;
    public float seconds = 1f;

    private float t;
    private Color start;

    private void Awake()
    {
        if (!sr) sr = GetComponent<SpriteRenderer>();
        if (sr) start = sr.color;
    }

    private void Update()
    {
        if (!sr) return;

        t += Time.deltaTime;
        float a = Mathf.Clamp01(1f - (t / seconds));

        Color c = start;
        c.a = a;
        sr.color = c;

        if (t >= seconds)
            Destroy(gameObject);
    }
}