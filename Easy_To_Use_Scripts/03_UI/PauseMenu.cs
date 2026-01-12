using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject panel;
    private bool paused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
            Time.timeScale = paused ? 0f : 1f;
            if (panel) panel.SetActive(paused);
        }
    }
}