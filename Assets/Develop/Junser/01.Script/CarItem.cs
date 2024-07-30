using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarItem : ItemScript
{
    protected override void SetPC()
    {
        playerLevel.ChangeToCar();
    }
    protected override void SetPlayer(GameObject other)
    {
        gameObject.SetActive(false);
    }
    protected override void SetUI()
    {
        stateUI.ChangeMovementUI(uiIndex);
    }
}
