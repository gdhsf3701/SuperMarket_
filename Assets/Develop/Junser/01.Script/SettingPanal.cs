using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingPanal : MonoBehaviour
{
    private void OnEnable()
    {
        Time.timeScale = 0;
    }
    public void Close()
    {
        gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ReLoad(string name)
    {
        LoadingScript.LoadScene(name);
    }
    public void Exit()
    {
        Application.Quit();
    }
    private void OnDisable()
    {
        Time.timeScale = 1;
    }
}
