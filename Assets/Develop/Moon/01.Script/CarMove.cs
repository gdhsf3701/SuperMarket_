using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    float speed = 0f;
    float maxSpeed = 25f;
    float minSpeed = 0f;
    float speedUpDownRate = 0.03f;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        speedChange();
        Move();
    }
    private void speedChange()
    {
        if (Input.GetKey(KeyCode.W))
        {
            speed += speedUpDownRate;
            if (speed>=maxSpeed)
            {
                speed = maxSpeed;
            }
        }
        if(Input.GetKey(KeyCode.S))
        {
            speed -= speedUpDownRate;
            if (speed<=minSpeed)
            {
                speed = minSpeed;
            }
        }
    }
    private void Move()
    {
        rb.velocity = transform.forward * speed;
    }
}
