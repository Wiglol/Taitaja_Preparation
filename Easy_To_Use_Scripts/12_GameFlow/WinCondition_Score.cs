using UnityEngine;

public class WinCondition_Score : MonoBehaviour
{
    public GameManager gm;
    public ScoreUI_LegacyText scoreUI;
    public int targetScore = 10;

    private void Update()
    {
        if (!gm || !scoreUI) return;
        if (gm.Current != GameManager.State.Playing) return;

        if (scoreUI.score >= targetScore)
            gm.Win();
    }
}