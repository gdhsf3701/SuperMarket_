using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    private int grapeSeed;
    private void OnTriggerEnter(Collider other)
    {
        grapeSeed = Random.Range(5, 9);
        Tomato.Instance.grapeSeed += grapeSeed;
        if (Tomato.Instance.grapeSeed > 50)
        {
            Tomato.Instance.grapeSeed = 50;
        }
        gameObject.SetActive(false);
    }
}
