using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float interval = 2f;
    public bool randomX = false;
    public float randomXRange = 3f;

    private float t;

    private void Update()
    {
        if (!prefab) return;

        t += Time.deltaTime;
        if (t >= interval)
        {
            Vector3 p = transform.position;
            if (randomX) p.x += Random.Range(-randomXRange, randomXRange);
            Instantiate(prefab, p, Quaternion.identity);
            t = 0f;
        }
    }
}