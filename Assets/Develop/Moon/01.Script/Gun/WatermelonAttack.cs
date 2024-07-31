using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonAttack : MonoBehaviour
{
    public GameObject SeedPrefab;
    public Transform firePoint;
    public float Angle;
    public float Power;

    public void Fire()
    {
        if (Tomato.Instance.Seed > 0)
        {
            GameObject seed = Instantiate(SeedPrefab, firePoint.position, firePoint.rotation);

            Rigidbody rb = seed.GetComponent<Rigidbody>();

            if (rb != null)
            {
                float radianAngle = Angle * Mathf.Deg2Rad;

                Vector3 forward = firePoint.forward;
                Vector3 direction = Quaternion.Euler(Angle, 0, 0) * forward;

                float xzPower = Mathf.Cos(radianAngle) * Power;
                float yPower = Mathf.Sin(radianAngle) * Power;

                Vector3 force = new Vector3(direction.x * xzPower, yPower, direction.z * xzPower);

                rb.AddForce(force, ForceMode.Impulse);
                Tomato.Instance.Seed--;
            }
        }
    }
}
