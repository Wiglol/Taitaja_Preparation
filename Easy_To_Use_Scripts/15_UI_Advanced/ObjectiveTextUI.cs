using UnityEngine;
using UnityEngine.UI;

public class ObjectiveTextUI : MonoBehaviour
{
    public Text text;

    private void Awake()
    {
        if (!text) text = GetComponent<Text>();
    }

    public void SetObjective(string msg)
    {
        if (text) text.text = msg;
    }
}