using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    protected Change playerLevel;
    [SerializeField]
    protected StateUI stateUI;
    [SerializeField]
    protected float resetTime;
    [SerializeField]
    protected int itemIndex, uiIndex;
    [SerializeField]
    bool playerChange;
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;
    private MeshRenderer itemMesh;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SetPlayer(other.gameObject);
            playerLevel = other.GetComponentInParent<Change>();
            SetPC();
            
        }
    }
    private void Awake()
    {
        stateUI = FindAnyObjectByType<StateUI>();
    }
    protected virtual void SetUI()
    {
        stateUI.ChangeBuffUI(uiIndex, resetTime);
    }

    protected virtual void SetPC()
    {
        playerLevel.ResetPlayer(resetTime);
    }
    protected virtual void SetPlayer(GameObject other)
    {
        gameObject.SetActive(false);
        playerLevel = other.GetComponentInParent<Change>();
        playerLevel.ChangeVisual(itemIndex);
    }
}
