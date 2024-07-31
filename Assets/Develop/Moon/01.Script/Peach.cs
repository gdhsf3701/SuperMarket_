using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peach : MonoBehaviour
{
    float invincibleTime = 5;
    float yUP = 1000;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Tomato.Instance.collison)
        {
            Tomato.Instance.hp = 1;
            Tomato.Instance.ScaleReset();
            transform.position = new Vector3(0, yUP, 0);
            StartCoroutine(InvincibleTime());
        }
    }
    IEnumerator InvincibleTime()
    {
        Tomato.Instance.invincible = true;
        float elapsedTime = 0f;

        while (elapsedTime < invincibleTime)
        {
            if (!Tomato.Instance.invincible)
            {
                Destroy(gameObject);
                yield break;
            }

            elapsedTime += Time.deltaTime;
            yield return null;
        }

        Tomato.Instance.invincible = false;
        Destroy(gameObject);
    }   
}
