using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Fall : MonoBehaviour
{
    [SerializeField ]private LayerMask groundLayer;
    private float groundCheckDistance = 0.9f;
    public bool isGrounded;
    private float startFallHeight;

    public float minFallDistance = 6.0f;

    private bool isFalling = false;

    private AirMove airMove;

    private void Awake()
    {
        airMove = GetComponent<AirMove>();
    }

    private void Update()
    {
        Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.red);
        FallCheck();
    }
    public void FallCheck()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundLayer);
        IsFall();
    }
    private void IsFall()
    {
        if (airMove.enabled)
        {
            isFalling = false;        
        }
        if(!isGrounded&&!isFalling&&!airMove.enabled)
        {
            isFalling = true;
            startFallHeight = transform.position.y;
        }
        else if(isFalling&&isGrounded&&!airMove.enabled)
        {
            float fallDistance = startFallHeight - transform.position.y;
            isFalling = false;
            if (fallDistance > minFallDistance)
            {
                Tomato.Instance.Hp = -101010;
            }
        }
    }
}
