using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;

    private bool isGrounded;

    private float speed= 5f;
    public float jumpForce = 5f;

    public LayerMask groundLayer;
    public float groundCheckDistance = 0.6f;

    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
    }
    private void Update()
    {
        PlayerMove();
        JumpCheck();
    }
    private void PlayerMove()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 moveVector = new Vector3(moveX, 0, moveZ);

        transform.position += moveVector.normalized * Time.deltaTime * speed;
    }
    private void JumpCheck()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
        Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.red);
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }
    private void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
