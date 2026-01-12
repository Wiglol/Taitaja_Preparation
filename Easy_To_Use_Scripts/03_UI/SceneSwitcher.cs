using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string targetScene;

    public void LoadTarget()
    {
        if (!string.IsNullOrEmpty(targetScene))
            SceneManager.LoadScene(targetScene);
    }

    public void Reload()
    {
        var current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(current.name);
    }

    public void Quit()
    {
        Application.Quit();
    }
}