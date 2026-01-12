using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameManager gm;
    public GameObject winPanel;

    private bool shown;

    private void Update()
    {
        if (shown) return;
        if (!gm || !winPanel) return;

        if (gm.Current == GameManager.State.Win)
        {
            winPanel.SetActive(true);
            shown = true;
        }
    }
}