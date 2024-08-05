
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    private float speed;
    Roll roll;
    bool spawn = false;

    private void Awake()
    {
        rb = GetComponentInChildren<Rigidbody>();
        roll = GetComponentInChildren<Roll>();
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
    }
    private void PlayerMove()
    {
        if (Input.GetKey(KeyCode.W))
        { 
            transform.position += transform.forward * Time.deltaTime * speed;
            roll.Rolling();
        }
    }
    public void SpeedChange()
    {
        speed = Tomato.Instance.defaultSpeed;
    }

    public void StopRolling()
    {
        rb.angularVelocity = Vector3.zero;
    }
}
