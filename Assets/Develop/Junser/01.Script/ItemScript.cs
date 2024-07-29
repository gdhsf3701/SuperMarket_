using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    protected Change playerLevel;

    [SerializeField]
    protected float resetTime;

    private MeshFilter meshFilter;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SetPlayer(other.gameObject);
            playerLevel = other.GetComponent<Change>();
            SetPC();
        }
    }
    
    protected virtual void SetPC()
    {
        playerLevel.ResetPlayer(resetTime);
    }
    private void SetPlayer(GameObject other)
    {
        gameObject.SetActive(false);
        playerLevel = other.GetComponent<Change>();
        meshFilter = other.GetComponent<MeshFilter>();
        meshFilter.mesh = gameObject.GetComponent<MeshFilter>().mesh;
    }
}
