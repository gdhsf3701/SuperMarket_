using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMove : MonoBehaviour
{
    private Rigidbody rb;
    private float speed;
    PlayerMovement player;

    float nowTime = 0;

    private void Awake()
    {
        rb = GetComponentInParent<Rigidbody>();
        player = GetComponent<PlayerMovement>();
        enabled = false;
    }
    private void Start()
    {
        speed = Tomato.Instance.defaultSpeed * 0.25f;
    }
    private void OnEnable()
    {
        rb.useGravity = false;
        nowTime = 0;
    }
    private void Update()
    {
        Up();
        PlayerMove();
        nowTime += Time.deltaTime;
        if (nowTime >= 3)
        {
            player.enabled = true;
            enabled = false;
        }
    }
    private void Up()
    {
        rb.velocity = new Vector3(rb.velocity.x, 1, rb.velocity.z);
    }
    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
    }
}
