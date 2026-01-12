using UnityEngine;

public class ClampToBounds2D : MonoBehaviour
{
    public Vector2 min = new Vector2(-10, -10);
    public Vector2 max = new Vector2(10, 10);

    private void LateUpdate()
    {
        Vector3 p = transform.position;
        p.x = Mathf.Clamp(p.x, min.x, max.x);
        p.y = Mathf.Clamp(p.y, min.y, max.y);
        transform.position = p;
    }
}