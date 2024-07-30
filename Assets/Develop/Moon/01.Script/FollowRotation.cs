using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRotation : MonoBehaviour
{
    GameObject game;
    private void Start()
    {
        game = transform.parent.transform.Find("Collison").gameObject;
    }
    private void Update()
    {
        transform.localRotation = game.transform.localRotation;
    }
}
