using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roll : MonoBehaviour
{
    public void Rolling()
    {
        Vector3 parentForward = transform.parent.right * -1;

        Quaternion rotation = Quaternion.AngleAxis(10, parentForward);

        transform.localRotation = transform.localRotation * Quaternion.Inverse(rotation);
    }
}
