using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Change : MonoBehaviour
{
    private Mesh _defaltMesh;
    [SerializeField]
    private MeshFilter _meshFilter;
    [SerializeField]
    GameObject _targetPrefab;
    private void Awake()
    {
        _defaltMesh = GetComponent<MeshFilter>().mesh;
    }

    public void ChangeMesh(MeshFilter target)
    {
        _meshFilter.mesh = target.mesh;
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
        Instantiate(_targetPrefab);
        ResetPlayer(time);
    }

    private IEnumerator ChangeCoolTime(float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<MeshFilter>().mesh = _defaltMesh;
    }
}
