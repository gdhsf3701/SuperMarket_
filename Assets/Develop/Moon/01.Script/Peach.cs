using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peach : MonoBehaviour
{
    float invincibleTime = 5;
    float yUP = 1000;
    private void OnTriggerEnter(Collider other)
    {
        Tomato.Instance.ScaleReset();
        transform.position = new Vector3(0, yUP, 0);
        StartCoroutine(InvincibleTime());
    }
    IEnumerator InvincibleTime()
    {
        Tomato.Instance.invincible = true;
        yield return new WaitForSeconds(invincibleTime);
        Tomato.Instance.invincible = false;
        Destroy(gameObject);
    }
}
