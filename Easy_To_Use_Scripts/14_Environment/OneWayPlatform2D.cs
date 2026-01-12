using UnityEngine;

public class OneWayPlatform2D : MonoBehaviour
{
    // This script is basically a reminder/setup helper.
    // Put PlatformEffector2D on your platform and set:
    // - Use One Way = true
    // - Surface Arc = 180 (typical)
    // Then add a Collider2D (NOT trigger).
    // You don't really need code for this mechanic, but it helps to have a template.

    [TextArea]
    public string notes = ""Add PlatformEffector2D + Collider2D (not trigger). Set One Way = true."";
}