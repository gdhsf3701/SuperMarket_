using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScript : MonoBehaviour
{
    public static string nextScene;
    [SerializeField]
    Image progressBar;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadScene());
    }

    public static void LoadScene(string sceneName)
    {
        nextScene = sceneName;
        SceneManager.LoadScene("Loading");
    }

    private IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;
        while (op.progress>0.9f)    
        {
            progressBar.transform.localPosition = new Vector3(Mathf.Lerp(-750, 760, op.progress), -350);
            progressBar.transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(0,360,op.progress));
            yield return null;
        }
        float timer = 0.0f;
        while (timer < 1.0f)
        {
            yield return null;
            timer += Time.deltaTime;
            progressBar.transform.localPosition = new Vector3(Mathf.Lerp(600, 760, timer), -350);
            progressBar.transform.rotation = Quaternion.Euler(0, 0, Mathf.Lerp(-180, -360, timer));
        }
        op.allowSceneActivation = true;
        yield return null;
    }
}
