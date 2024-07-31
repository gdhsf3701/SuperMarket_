using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManager : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("Loading");
    }
    public void quitBtn()
    {
        Application.Quit();
    }
}
