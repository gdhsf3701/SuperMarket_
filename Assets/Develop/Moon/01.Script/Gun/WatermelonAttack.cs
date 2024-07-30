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
        GameObject seed = Instantiate(SeedPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = seed.GetComponent<Rigidbody>();

        if (rb != null)
        {
            float radianAngle = Angle * Mathf.Deg2Rad;

            Vector3 force = new Vector3(Mathf.Cos(radianAngle), Mathf.Sin(radianAngle), 0) * Power;

            rb.AddForce(force, ForceMode.Impulse);
        }
    }
}
