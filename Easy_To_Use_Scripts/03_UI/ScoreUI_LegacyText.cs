using UnityEngine;
using UnityEngine.UI;

public class ScoreUI_LegacyText : MonoBehaviour
{
    public Text text;
    public int score;

    public void Set(int value) { score = value; Refresh(); }
    public void Add(int amount) { score += amount; Refresh(); }

    public void Refresh()
    {
        if (text) text.text = $""Score: {score}"";
    }
}