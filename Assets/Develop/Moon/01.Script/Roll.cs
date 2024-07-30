using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    public void Rolling()
    {
        Vector3 parentForward = transform.parent.forward;

        Quaternion rotation = Quaternion.AngleAxis(10, parentForward);

        transform.localRotation = transform.localRotation * rotation;
    }
}
