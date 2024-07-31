using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    Fire fire;
    int randam;
    private void OnTriggerEnter(Collider other)
    {
        fire = GameObject.Find("Fire").GetComponent<Fire>();
        randam = Random.Range(1, 11);
        if (!fire.melon)
        {
            switch (randam)
            {
                default:
                    break;
                case 1:
                case 2:
                    Tomato.Instance.Seed += 5;
                    break;
                case 3:
                case 4:
                case 5:
                    Tomato.Instance.Seed += 4;
                    break;
            }
            
        }
        else
        {
            switch (randam)
            {
                default:
                    break;
                case 1:
                    Tomato.Instance.Seed += 12;
                    break;
                case 2:
                case 3:
                    Tomato.Instance.Seed += 10;
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                    Tomato.Instance.Seed += 6;
                    break;

            }
        }
        Destroy(gameObject);
    }
}
