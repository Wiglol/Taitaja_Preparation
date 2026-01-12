using UnityEngine;

public class RotateToMouse2D : MonoBehaviour
{
    public Camera cam;

    private void Awake()
    {
        if (!cam) cam = Camera.main;
    }

    private void Update()
    {
        Vector3 world = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 dir = (world - transform.position);
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, angle);
    }
}