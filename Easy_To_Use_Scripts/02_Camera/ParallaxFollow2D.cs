using UnityEngine;

public class ParallaxFollow2D : MonoBehaviour
{
    [Range(0f, 1f)]
    public float parallaxFactor = 0.5f;

    private Transform camT;
    private Vector3 last;

    private void Start()
    {
        camT = Camera.main.transform;
        last = camT.position;
    }

    private void LateUpdate()
    {
        Vector3 delta = camT.position - last;
        transform.position += delta * parallaxFactor;
        last = camT.position;
    }
}