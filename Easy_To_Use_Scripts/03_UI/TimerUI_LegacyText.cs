using UnityEngine;
using UnityEngine.UI;

public class TimerUI_LegacyText : MonoBehaviour
{
    public Text text;
    public bool countDown = true;
    public float startTime = 60f;

    private float t;

    private void Start()
    {
        t = startTime;
    }

    private void Update()
    {
        t += countDown ? -Time.deltaTime : Time.deltaTime;
        if (countDown && t < 0f) t = 0f;
        if (text) text.text = $""Time: {Mathf.CeilToInt(t)}"";
    }
}