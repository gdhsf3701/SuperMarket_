using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    private float speed = 5f;

    private Rigidbody rb;
    Jump jump;
    WakeUp wakeUp;
    private void Awake()
    {
        wakeUp = GetComponent<WakeUp>();
        jump = GetComponent<Jump>();
        rb = GetComponentInParent<Rigidbody>();
        enabled = false;
    }
    private void OnEnable()
    {
        rb.useGravity = true;
    }
    private void Update()
    {
        PlayerMove();
        if(Input.GetKeyDown(KeyCode.R) && !wakeUp.warking)
        {
            StartCoroutine(wakeUp.WakeUpRotation());
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump.JumpCheck();
        }
    }
    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * speed;
        }

    }
    
}
