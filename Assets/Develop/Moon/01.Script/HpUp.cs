using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Tomato.Instance.collison)
        {
            Tomato.Instance.hp += 1;
        }
    }
}
