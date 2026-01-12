12_GameFlow (Unity 2022 LTS)
----------------------------
Goal: quick "game states" so you can finish tasks cleanly.

Typical setup:
- Create empty object "GameManager"
- Add GameManager.cs
- Hook UI panels (menu, win, lose)
- Use SceneSwitcher (03_UI) for scene loading buttons.

Scripts:
- GameManager: central state (Menu/Playing/Win/Lose)
- WinCondition_Time: win after time
- WinCondition_Score: win when score >= target
- LoseCondition_Health: lose when Health hits 0
- RestartOnFail: reload scene on R (optional)