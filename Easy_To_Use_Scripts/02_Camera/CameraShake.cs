using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Vector3 start;
    private float timeLeft;
    private float strength;

    private void Awake()
    {
        start = transform.localPosition;
    }

    private void Update()
    {
        if (timeLeft > 0f)
        {
            timeLeft -= Time.deltaTime;
            transform.localPosition = start + (Vector3)Random.insideUnitCircle * strength;
        }
        else
        {
            transform.localPosition = start;
        }
    }

    public void Shake(float duration, float s)
    {
        timeLeft = duration;
        strength = s;
    }
}