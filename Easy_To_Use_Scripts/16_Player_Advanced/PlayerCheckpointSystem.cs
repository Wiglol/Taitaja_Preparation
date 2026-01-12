using UnityEngine;

public class PlayerCheckpointSystem : MonoBehaviour
{
    public Vector3 CurrentCheckpoint { get; private set; }

    private void Start()
    {
        CurrentCheckpoint = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(""Checkpoint""))
            CurrentCheckpoint = other.transform.position;
    }
}