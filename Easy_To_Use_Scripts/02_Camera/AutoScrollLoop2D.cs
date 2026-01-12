using UnityEngine;

public class AutoScrollLoop2D : MonoBehaviour
{
    public float speed = 2f;
    public Transform[] tiles;

    private float tileWidth;

    private void Awake()
    {
        if (tiles == null || tiles.Length == 0)
        {
            tiles = new Transform[transform.childCount];
            for (int i = 0; i < tiles.Length; i++)
                tiles[i] = transform.GetChild(i);
        }

        var sr = tiles[0].GetComponent<SpriteRenderer>();
        tileWidth = sr ? sr.bounds.size.x : 10f;
    }

    private void Update()
    {
        float dx = speed * Time.deltaTime;

        foreach (var t in tiles)
            t.position += Vector3.left * dx;

        foreach (var t in tiles)
        {
            Vector3 rightEdge = t.position + Vector3.right * (tileWidth * 0.5f);
            Vector3 view = Camera.main.WorldToViewportPoint(rightEdge);

            if (view.x < 0f)
            {
                Transform rightmost = tiles[0];
                for (int i = 1; i < tiles.Length; i++)
                    if (tiles[i].position.x > rightmost.position.x)
                        rightmost = tiles[i];

                t.position = new Vector3(rightmost.position.x + tileWidth, t.position.y, t.position.z);
            }
        }
    }
}