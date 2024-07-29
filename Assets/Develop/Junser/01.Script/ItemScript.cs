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
            playerLevel = other.GetComponentInParent<Change>();
            SetPC();
        }
    }
    
    protected virtual void SetPC()
    {
        playerLevel.ResetPlayer(resetTime);
    }
    protected virtual void SetPlayer(GameObject other)
    {
        playerLevel = other.GetComponentInParent<Change>();
        playerLevel.ChangeMesh(GetComponent<MeshFilter>());
        gameObject.SetActive(false);
    }
}
