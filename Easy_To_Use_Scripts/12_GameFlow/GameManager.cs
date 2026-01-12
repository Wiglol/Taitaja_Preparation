using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum State { Menu, Playing, Win, Lose }

    [Header(""UI Panels (optional)"")]
    public GameObject menuPanel;
    public GameObject winPanel;
    public GameObject losePanel;

    [Header(""Start State"")]
    public State startState = State.Menu;

    public State Current { get; private set; }

    private void Start()
    {
        SetState(startState);
    }

    public void SetState(State s)
    {
        Current = s;

        if (menuPanel) menuPanel.SetActive(s == State.Menu);
        if (winPanel)  winPanel.SetActive(s == State.Win);
        if (losePanel) losePanel.SetActive(s == State.Lose);

        // timeScale rules:
        // Playing = unpaused, others = paused (common competition pattern)
        Time.timeScale = (s == State.Playing) ? 1f : 0f;
    }

    public void StartGame() => SetState(State.Playing);
    public void Win()       => SetState(State.Win);
    public void Lose()      => SetState(State.Lose);
}