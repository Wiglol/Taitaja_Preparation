13_AI_Behaviour (Unity 2022 LTS)
--------------------------------
Goal: fast enemy behaviours with minimal setup.

Common setup:
- Enemy has Rigidbody2D (optional), Collider2D
- Use transform-based movement (MoveTowards) for speed and simplicity.

Scripts:
- EnemyIdleThenChase2D: waits, then chases player in radius
- EnemyPatrolThenChase2D: patrol A<->B until player enters radius
- EnemyTurnAtEdge2D: flips direction at ledges (raycast down)
- EnemyShootWhenInRange2D: turret-style shooting when player close

Tags:
- Player must be tagged ""Player"".