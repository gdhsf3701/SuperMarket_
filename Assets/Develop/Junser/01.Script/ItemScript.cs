using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField]
    private int expAmount;
    private Change playerLevel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            playerLevel = other.GetComponent<Change>();
            playerLevel.TakeXP(expAmount);
            other.AddComponent<>();
        }
    }
}
