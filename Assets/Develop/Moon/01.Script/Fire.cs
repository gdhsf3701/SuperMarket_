using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    GrapeAttack grape;
    WatermelonAttack watermelon;
    private void Awake()
    {
        grape = GetComponent<GrapeAttack>();
        watermelon = GetComponent<WatermelonAttack>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grape.Fire();
        }
        if(Input.GetMouseButtonDown(1))
        {
            watermelon.Fire();
        }
    }
}
