using UnityEngine;
using UnityEngine.UI;

public class ScorePopupText : MonoBehaviour
{
    public Text text;
    public float floatUpSpeed = 30f;
    public float life = 0.8f;

    private float t;

    private void Awake()
    {
        if (!text) text = GetComponent<Text>();
    }

    public void Set(string msg)
    {
        if (text) text.text = msg;
    }

    private void Update()
    {
        transform.position += Vector3.up * floatUpSpeed * Time.deltaTime;

        t += Time.deltaTime;
        if (t >= life) Destroy(gameObject);
    }
}