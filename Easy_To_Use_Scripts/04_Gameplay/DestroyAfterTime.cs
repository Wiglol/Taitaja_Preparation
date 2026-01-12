using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifeTime = 3f;
    private float t;

    private void Update()
    {
        t += Time.deltaTime;
        if (t >= lifeTime) Destroy(gameObject);
    }
}