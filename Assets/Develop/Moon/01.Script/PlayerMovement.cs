using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    private float speed= 5f;
    Jump jump;

    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
        jump = GetComponentInParent<Jump>();
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
        //    float moveX = Input.GetAxis("Horizontal");
        //    float moveZ = Input.GetAxis("Vertical");
        //    Vector3 moveVector = new Vector3(moveX, 0, moveZ);
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }
}
