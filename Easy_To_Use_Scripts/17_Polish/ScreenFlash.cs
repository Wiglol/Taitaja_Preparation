using UnityEngine;
using UnityEngine.UI;

public class ScreenFlash : MonoBehaviour
{
    public Image image;
    public float flashTime = 0.15f;

    private float t;
    private bool active;

    private void Awake()
    {
        if (!image) image = GetComponent<Image>();
        if (image)
        {
            Color c = image.color;
            c.a = 0f;
            image.color = c;
        }
    }

    public void Flash()
    {
        t = flashTime;
        active = true;

        if (image)
        {
            Color c = image.color;
            c.a = 1f;
            image.color = c;
        }
    }

    private void Update()
    {
        if (!active || !image_toggle()) return;
    }

    private bool image_toggle()
    {
        if (!image) return false;

        if (t > 0f)
        {
            t -= Time.unscaledDeltaTime;
            float a = Mathf.Clamp01(t / flashTime);
            Color c = image.color;
            c.a = a;
            image.color = c;
        }
        else
        {
            active = false;
            Color c = image.color;
            c.a = 0f;
            image.color = c;
        }

        return true;
    }
}