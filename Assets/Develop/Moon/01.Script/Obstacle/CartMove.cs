using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartMove : MonoBehaviour
{
    float speed = 75f;
    Rigidbody rb;

    bool nowarked = true;
    bool end = false;

    float time=0;
    float maxtime = 1;

    GameObject Warning;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Warning = GetComponentsInChildren<Transform>()[2].gameObject;
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
                rb.AddForce(transform.forward * speed, ForceMode.Impulse);
            }
            else
            {
                time += Time.deltaTime;
            }
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (nowarked)
        {
            nowarked = false;
            Warning.SetActive(true);
        }
    }
}
