using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public Vector3 degreesPerSecond = new Vector3(0, 0, 180);

    private void Update()
    {
        transform.Rotate(degreesPerSecond * Time.deltaTime);
    }
}