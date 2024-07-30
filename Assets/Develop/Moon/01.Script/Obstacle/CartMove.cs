using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMove : MonoBehaviour
{
    float power = 2000f;
    Rigidbody rb;

    bool nowarked = true;
    bool end = false;

    float time=0;
    float maxtime = 2f;

    float delTime = 0; 

    GameObject Warning;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Warning = GetComponentsInChildren<Transform>()[4].gameObject;
        Warning.SetActive(false);
    }
    private void Update()
    {
        if (!nowarked)
        {
            if (time >= maxtime&&!end)
            {
                end = true;
                Warning.SetActive(false);
                rb.AddForce(transform.forward * power, ForceMode.Impulse);
            }
            else
            {
                time += Time.deltaTime;
            }
        }
        if (end)
        {
            if(delTime>=maxtime+0.3f)
            {
                Destroy(gameObject);
            }
            else
            {
                delTime += Time.deltaTime;
            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (nowarked && collision.gameObject == Tomato.Instance.collison)
        {
            Warning.SetActive(true);
            nowarked = false;
            Destroy(GetComponent<BoxCollider>());
        }
    }
}
