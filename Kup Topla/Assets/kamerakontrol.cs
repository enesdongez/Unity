using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class kamerakontrol : MonoBehaviour
{
    public GameObject top;
    Vector3 aradakimesafe;


    void Start()
    {
        aradakimesafe = transform.position - top.transform.position;
    }

  
    void LateUpdate()
    {
        transform.position = top.transform.position + aradakimesafe;
    }
}
