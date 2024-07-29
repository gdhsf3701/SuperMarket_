using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneItem : ItemScript
{
    protected override void SetPC()
    {
        playerLevel.ResetPlayer(GetComponent<MeshFilter>().mesh, resetTime);
        playerLevel.ChangeToAirplane();
    }
    protected override void SetPlayer(GameObject other)
    {
        gameObject.SetActive(false);
    }
}
