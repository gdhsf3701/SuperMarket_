using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tomato : MonoBehaviour
{
    public static Tomato Instance = null;
    public int waterSeed = 0;
    public int grapeSeed = 0;
    public int colaCount = 0;
    public bool invincible = false;
    public float defaultSpeed = 5;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            waterSeed = 0;
            grapeSeed = 0;
            colaCount = 0;
            invincible = false;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
