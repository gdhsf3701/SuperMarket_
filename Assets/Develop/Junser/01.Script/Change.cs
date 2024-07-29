using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Change : MonoBehaviour
{
    
    private void ChangeToCar()
    {
        PlayerMovement movement = GetComponent<PlayerMovement>();
        movement.enabled = false;
        CarMove car = GetComponent<CarMove>();
        car.enabled = true;
    }
}
