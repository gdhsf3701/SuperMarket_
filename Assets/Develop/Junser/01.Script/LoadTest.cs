using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LoadingScript.LoadScene("EnemyTest");
    }
}
