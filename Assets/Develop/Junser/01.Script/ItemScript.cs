using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField]
    private int expAmount;
    private Change playerLevel;

    private MeshFilter meshFilter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            playerLevel = other.GetComponent<Change>();
            meshFilter = other.GetComponent<MeshFilter>();
            meshFilter.mesh = gameObject.GetComponent<MeshFilter>().mesh;
        }
    }
}
