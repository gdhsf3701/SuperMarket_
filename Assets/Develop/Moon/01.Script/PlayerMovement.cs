using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    private float speed;
    Jump jump;

    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
        jump = GetComponentInParent<Jump>();
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
    }
}
