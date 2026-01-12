using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    public Health playerHealth;
    public GameObject losePanel;

    private bool shown;

    private void Update()
    {
        if (shown) return;
        if (!playerHealth || !losePanel) return;

        if (playerHealth.CurrentHP <= 0)
        {
            losePanel.SetActive(true);
            shown = true;
            Time.timeScale = 0f;
        }
    }
}