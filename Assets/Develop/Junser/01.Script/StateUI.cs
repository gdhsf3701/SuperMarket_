using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateUI : MonoBehaviour
{
    [SerializeField]
    private Sprite[] buffs;

    [SerializeField]
    Image  buffUI;
    public void ChangeBuffUI(int index, float time)
    {
        buffUI.sprite = buffs[index];
        StartCoroutine(ResetUI(time));
    }
    public void ChangeBuffUI(int index)
    {
        buffUI.sprite = buffs[index];
    }

    private IEnumerator ResetUI(float time)
    {
        yield return new WaitForSeconds(time);
        buffUI.sprite = null;
    }
}
