using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirMove : MonoBehaviour
{
    float speed;
    float XYRate=1f;
    Rigidbody rb;
    [SerializeField]float RotationX = 0;
    [SerializeField]float RotationY = 0;
    private void Awake()
    {
        RotationX = transform.rotation.x;
        RotationY = transform.rotation.y;
        rb = GetComponent<Rigidbody>();
        enabled = false;
    }
    private void OnEnable()
    {
        rb.useGravity = false;
    }
    private void Start()
    {
        speed = Tomato.Instance.defaultSpeed * 2.5f;
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
            RotationX = Mathf.Clamp(RotationX + XYRate,-30,30);
        }
        if (Input.GetKey(KeyCode.S))
        {
            RotationX = Mathf.Clamp(RotationX - XYRate, -30, 30);
        }
    }
    private void YChange()
    {
        if (Input.GetKey(KeyCode.A))
        {
            RotationY -= XYRate;
        }
        if (Input.GetKey(KeyCode.D))
        {
            RotationY += XYRate;
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
