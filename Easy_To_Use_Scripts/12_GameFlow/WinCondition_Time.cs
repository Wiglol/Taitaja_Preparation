using UnityEngine;

public class WinCondition_Time : MonoBehaviour
{
    public GameManager gm;
    public float secondsToWin = 30f;
    public bool requirePlayingState = true;

    private float t;

    private void Update()
    {
        if (!gm) return;
        if (requirePlayingState && gm.Current != GameManager.State.Playing) return;

        t += Time.deltaTime;
        if (t >= secondsToWin)
            gm.Win();
    }
}