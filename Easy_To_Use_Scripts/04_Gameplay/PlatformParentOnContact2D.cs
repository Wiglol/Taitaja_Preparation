using UnityEngine;

public class PlatformParentOnContact2D : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.CompareTag(""Player""))
            c.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D c)
    {
        if (c.gameObject.CompareTag(""Player""))
            c.transform.SetParent(null);
    }
}