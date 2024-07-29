using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarItem : ItemScript
{
    protected override void SetPC()
    {
        playerLevel.ResetPlayer(GetComponent<MeshFilter>().mesh,resetTime);
        playerLevel.ChangeToCar();
    }
}
