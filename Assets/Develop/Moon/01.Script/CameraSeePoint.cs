using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSeePoint : MonoBehaviour
{
    public float turnSpeed=100;
    [SerializeField]GameObject child;
    private void OnEnable()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float r = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * r);
        Vector3 childPositionBackup = child.transform.position;
        transform.position = child.transform.position;
        child.transform.position = childPositionBackup;
    }
}
