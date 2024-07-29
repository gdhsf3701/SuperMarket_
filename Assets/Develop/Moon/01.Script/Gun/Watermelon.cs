using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watermelon : MonoBehaviour
{
    private int watermelonSeed;
    private void OnTriggerEnter(Collider other)
    {
        watermelonSeed = Random.Range(13, 16);
        Tomato.Instance.waterSeed += watermelonSeed;
        if (Tomato.Instance.waterSeed > 50)
        {
            Tomato.Instance.waterSeed = 50;
        }
        gameObject.SetActive(false);
    }
}
