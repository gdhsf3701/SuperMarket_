using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WakeUp : MonoBehaviour
{
    private float wakeUpTime = 6f;
    Jump jump;
    Rigidbody rb;
    private bool isGrounded;
    public bool warking = false;
    CameraSeePoint cameraSeePoint;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        cameraSeePoint = GetComponentInParent<CameraSeePoint>();
        jump = GetComponentInParent<Jump>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !warking)
        {
            StartCoroutine(WakeUpRotation());
        }
    }
    public IEnumerator WakeUpRotation()
    {
        warking = true;
        cameraSeePoint.turnSpeed=0;
        yield return new WaitForSeconds(wakeUpTime);
        isGrounded = Physics.Raycast(transform.position, Vector3.down, jump.groundCheckDistance, jump.groundLayer);
        if(isGrounded)
        {
            Vector3 newRotation = new Vector3(0, transform.rotation.y, 0);
            transform.rotation = Quaternion.Euler(newRotation);
            rb.velocity = Vector3.zero;
        }
        cameraSeePoint.turnSpeed = 100;
        warking = false;
    }
}
