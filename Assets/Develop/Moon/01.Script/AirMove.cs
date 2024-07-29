using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirMove : MonoBehaviour
{
    float speed = 12.5f;
    float XYRate=1f;
    Rigidbody rb;
    [SerializeField]float RotationX = 0;
    [SerializeField]float RotationY = 0;
    private void Awake()
    {
        RotationX = transform.rotation.x;
        RotationY = transform.rotation.y;
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        rb.useGravity = false;
    }
    private void Update()
    {
        XChange();
        YChange();
        RotationMove();
        Move();
    }
    private void XChange()
    {
        if (Input.GetKey(KeyCode.W))
        {
            RotationX += XYRate;
        }
        if (Input.GetKey(KeyCode.S))
        {
            RotationX -= XYRate;
        }
    }
    private void YChange()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotationY += XYRate;
        }
        if (Input.GetKey(KeyCode.D))
        {
            RotationY -= XYRate;
        }
    }
    private void RotationMove()
    {
        transform.rotation = Quaternion.Euler(RotationX, RotationY, transform.rotation.z);
    }
    private void Move()
    {
        rb.velocity = transform.forward * speed;
    }
}
