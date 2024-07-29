using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeePoint : MonoBehaviour
{
    private float turnSpeed=100;
    void Update()
    {
        float r = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);
    }
}
