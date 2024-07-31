using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;

    Fall fall;

    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponentInChildren<Rigidbody>();
    }
    public void JumpCheck()
    {
        if (fall.isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jumping();
        }
    }
    private void Jumping()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
