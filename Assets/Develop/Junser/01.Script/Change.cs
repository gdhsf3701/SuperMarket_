using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class Change : MonoBehaviour
{
    private Mesh _defaltMesh;
    [SerializeField]
    private MeshFilter _meshFilter;
    [SerializeField]
    GameObject _carPrefab,_airplain;

    private GameObject _currentState;
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
        Destroy(_currentState);
        PlayerMovement movement = GetComponent<PlayerMovement>();
        movement.enabled = false;
        CarMove car = GetComponent<CarMove>();
        car.enabled = true;
        GameObject carPrefab = Instantiate(_carPrefab, transform.position, transform.rotation, transform);
        carPrefab.transform.localPosition = Vector3.zero;
        _currentState = carPrefab;
    }
    public void ChangeToAirplane()
    {
        Destroy( _currentState);
        CarMove car = GetComponent<CarMove>();
        car.enabled = false;
        AirMove airplane = GetComponent<AirMove>();
        airplane.enabled = true;
        GameObject carPrefab = Instantiate(_airplain, transform.position, transform.rotation, transform);
        carPrefab.transform.localPosition = Vector3.zero;
    }

    public void ResetPlayer(float time)
    {
        StartCoroutine(ChangeCoolTime(time));
    }

    

    private IEnumerator ChangeCoolTime(float time)
    {
        yield return new WaitForSeconds(time);
        GetComponent<MeshFilter>().mesh = _defaltMesh;
    }
}
