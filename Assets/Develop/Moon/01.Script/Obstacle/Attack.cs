using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == Tomato.Instance.collison)
        {
            Tomato.Instance.Hp-=1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Tomato.Instance.collison)
        {
            Tomato.Instance.Hp-=1;
        }
    }
}
