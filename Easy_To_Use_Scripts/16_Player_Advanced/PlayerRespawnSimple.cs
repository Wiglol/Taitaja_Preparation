using UnityEngine;

public class PlayerRespawnSimple : MonoBehaviour
{
    public Health health;
    public PlayerCheckpointSystem checkpoints;

    private void Awake()
    {
        if (!health) health = GetComponent<Health>();
        if (!checkpoints) checkpoints = GetComponent<PlayerCheckpointSystem>();
    }

    private void OnEnable()
    {
        if (health != null) health.onDeath += Respawn;
    }

    private void OnDisable()
    {
        if (health != null) health.onDeath -= Respawn;
    }

    private void Respawn()
    {
        if (!checkpoints) return;

        // "revive"
        health.Heal(health.MaxHP);
        transform.position = checkpoints.CurrentCheckpoint;
    }
}