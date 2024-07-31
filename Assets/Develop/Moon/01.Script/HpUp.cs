using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Tomato.Instance.collison)
        {
            Tomato.Instance.invincible = false;
            Tomato.Instance.hp += 1;
            for (int i = 0; i < transform.childCount; i++)
            {
                Tomato.Instance.transform.GetChild(i).localScale *= 1.25f;
            }
            Destroy(gameObject);
        }
    }
}
