using UnityEngine;

public class RestartOnFail : MonoBehaviour
{
    public GameManager gm;
    public SceneSwitcher sceneSwitcher;

    private void Update()
    {
        if (!gm || !sceneSwitcher) return;

        if (gm.Current == GameManager.State.Win || gm.Current == GameManager.State.Lose)
        {
            if (Input.GetKeyDown(KeyCode.R))
                sceneSwitcher.Reload();
        }
    }
}