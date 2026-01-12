using UnityEngine;

public class CollectibleScore2D : MonoBehaviour
{
    public int points = 1;
    public ScoreUI_LegacyText scoreUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag(""Player"")) return;
        if (scoreUI) scoreUI.Add(points);
        Destroy(gameObject);
    }
}