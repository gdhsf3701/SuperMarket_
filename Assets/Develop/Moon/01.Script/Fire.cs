using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    GrapeAttack grape;
    WatermelonAttack watermelon;
    
    public bool melon=false;
    private void Awake()
    {
        grape = GetComponent<GrapeAttack>();
        watermelon = GetComponent<WatermelonAttack>();
    }
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (melon)
            {
                watermelon?.Fire(); 
            }
            else
            {
                grape?.Fire();
            }
        }
    }
}
