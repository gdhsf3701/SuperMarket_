using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Change : MonoBehaviour
{
    private Mesh _defaltMesh;

    private void Awake()
    {
        _defaltMesh = GetComponent<MeshFilter>().mesh;
    }
    public void ChangeToCar()
    {
        PlayerMovement movement = GetComponent<PlayerMovement>();
        movement.enabled = false;
        CarMove car = GetComponent<CarMove>();
        car.enabled = true;
    }
    public void ChangeToAirplane()
    {
        CarMove car = GetComponent<CarMove>();
        car.enabled = false;
        AirMove airplane = GetComponent<AirMove>();
        airplane.enabled = true;
    }

    public void ResetPlayer(float time)
    {
        StartCoroutine(ChangeCoolTime(time));
    }

    public void ResetPlayer(Mesh settingMesh, float time)
    {
        _defaltMesh = settingMesh;
        ResetPlayer(time);
    }

    private IEnumerator ChangeCoolTime(float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<MeshFilter>().mesh = _defaltMesh;
    }
}
