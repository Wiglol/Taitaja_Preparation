using UnityEngine;

public class ScalePulse : MonoBehaviour
{
    public float amount = 0.08f;
    public float speed = 3f;

    private Vector3 baseScale;

    private void Start()
    {
        baseScale = transform.localScale;
    }

    private void Update()
    {
        float k = 1f + Mathf.Sin(Time.time * speed) * amount;
        transform.localScale = baseScale * k;
    }
}