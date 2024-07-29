using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;

    public LayerMask groundLayer;
    public float groundCheckDistance = 0.6f;
    private bool isGrounded;

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
    }
    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.red);
    }
    public void JumpCheck()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jumping();
        }
    }
    private void Jumping()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
