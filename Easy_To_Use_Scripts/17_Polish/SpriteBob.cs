using UnityEngine;

public class SpriteBob : MonoBehaviour
{
    public float amplitude = 0.15f;
    public float frequency = 2f;

    private Vector3 start;

    private void Start()
    {
        start = transform.position;
    }

    private void Update()
    {
        float y = Mathf.Sin(Time.time * frequency) * amplitude;
        transform.position = start + Vector3.up * y;
    }
}