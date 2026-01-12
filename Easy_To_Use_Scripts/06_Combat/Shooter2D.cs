using UnityEngine;

public class Shooter2D : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float cooldown = 0.2f;

    private float cd;

    private void Update()
    {
        cd -= Time.deltaTime;

        if (Input.GetMouseButton(0) && cd <= 0f)
        {
            if (projectilePrefab && firePoint)
                Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);

            cd = cooldown;
        }
    }
}