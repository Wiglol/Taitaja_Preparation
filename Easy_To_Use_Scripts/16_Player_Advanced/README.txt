16_Player_Advanced (Unity 2022 LTS)
-----------------------------------
Player helpers that usually show up in tasks.

Scripts:
- PlayerCheckpointSystem: saves respawn points via trigger checkpoints
- PlayerRespawnSimple: respawn on death using saved checkpoint
- PlayerKnockbackReceiver: apply knockback when damaged
- PlayerAnimationController2D: sets Animator parameters (speed/grounded)

Notes:
- Checkpoints should be triggers tagged ""Checkpoint"".