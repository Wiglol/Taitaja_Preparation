using UnityEngine;

public class InvincibilityFrames : MonoBehaviour
{
    public float seconds = 0.8f;
    private float t;

    public bool CanTakeHit() => t <= 0f;
    public void Trigger() => t = seconds;

    private void Update()
    {
        if (t > 0f) t -= Time.deltaTime;
    }
}