using UnityEngine;

public class LoseCondition_Health : MonoBehaviour
{
    public GameManager gm;
    public Health playerHealth;

    private void Update()
    {
        if (!gm || !playerHealth) return;
        if (gm.Current != GameManager.State.Playing) return;

        if (playerHealth.CurrentHP <= 0)
            gm.Lose();
    }
}