using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    private int grapeSeed;
    private void OnTriggerEnter(Collider other)
    {
        grapeSeed = Random.Range(5, 9);
        Tomato.Instance.Seed += grapeSeed;
        if (Tomato.Instance.Seed > 20)
        {
            Tomato.Instance.Seed = 20;
        }
        gameObject.SetActive(false);
    }
}
