using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoItem : ItemScript
{
    protected override void SetUI()
    {
        stateUI.ChangeBuffUI(uiIndex);
    }
}
