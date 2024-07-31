using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneSound : MonoBehaviour
{
    private void Awake()
    {
       DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "art")
        {
            Destroy(gameObject);
        }
    }
}
