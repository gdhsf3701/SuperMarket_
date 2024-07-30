using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotMove : MonoBehaviour
{
    private float speed;

    private Rigidbody rb;
    Jump jump;
    private void Awake()
    {
        jump = GetComponent<Jump>();
        rb = GetComponentInChildren<Rigidbody>();
        enabled = false;
    }
    private void Start()
    {
        speed = Tomato.Instance.defaultSpeed;
    }
    private void OnEnable()
    {
        rb.useGravity = true;
    }
    private void Update()
    {
        PlayerMove();
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
    public void SpeedChange()
    {
        speed = Tomato.Instance.defaultSpeed;
    }

}
