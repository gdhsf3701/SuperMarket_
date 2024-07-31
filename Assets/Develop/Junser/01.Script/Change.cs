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

    [SerializeField]
    GameObject[] visual;

    [SerializeField]
    PlayerMovement movement;

    private PrefabOverride _prefabOverride;

    private MeshRenderer _material;
    private Material[] _defaltMaterial;

    private GameObject _currentState;

    public void ChangeVisual(int index)
    {
        for (int i = 0; i < visual.Length; i++)
        {
            visual[i].gameObject.SetActive(i == index);
        }
    }
    public void ChangeToCar()
    {
        Destroy(_currentState);
        PlayerMovement movement = GetComponent<PlayerMovement>();
        movement.enabled = false;
        CarMove car = GetComponent<CarMove>();
        transform.rotation = Quaternion.Euler(0, 0, 0);
        car.enabled = true;
        AirMove airplane = GetComponent<AirMove>();
        airplane.enabled = false;
        GameObject carPrefab = Instantiate(_carPrefab, transform.position, transform.rotation*Quaternion.Euler(0,90,0), transform);
        carPrefab.transform.localPosition = Vector3.zero;
        _currentState = carPrefab;
        movement.StopRolling();
        transform.position = transform.position + new Vector3(0,1,0);
        
    }
    public void ChangeToAirplane()
    {
        Destroy( _currentState);
        CarMove car = GetComponent<CarMove>();
        car.enabled = false;
        AirMove airplane = GetComponent<AirMove>();
        airplane.enabled = true;
        GameObject carPrefab = Instantiate(_airplain, transform.position, transform.rotation * Quaternion.Euler(0, -90, 0), transform);
        carPrefab.transform.localPosition = Vector3.zero;
        _currentState = carPrefab;
        movement.StopRolling();
    }

    public void ResetPlayer(float time)
    {
        StartCoroutine(ChangeCoolTime(time));
    }

    

    private IEnumerator ChangeCoolTime(float time)
    {
        yield return new WaitForSeconds(time);
        ChangeVisual(0);
    }
}
