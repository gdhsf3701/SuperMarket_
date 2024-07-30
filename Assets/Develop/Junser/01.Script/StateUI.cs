using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateUI : MonoBehaviour
{
    [SerializeField]
    protected Sprite[] movements, buffs;

    [SerializeField]
    Image movementUI, buffUI;
    public void ChangeMovementUI(int index)
    {
        movementUI.sprite = movements[index];
    }
    public void ChangeBuffUI(int index, float time)
    {
        buffUI.sprite = buffs[index];
        StartCoroutine(ResetUI(time));
    }

    private IEnumerator ResetUI(float time)
    {
        yield return new WaitForSeconds(time);
        buffUI.sprite = null;
    }
}
