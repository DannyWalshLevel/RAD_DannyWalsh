using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowballcontrolscript : MonoBehaviour
{
    Rigidbody rb;
    internal int check = 5; 
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void ImThrowingYou(CubeControlScript cubeControlScript)
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 1, -4);
        transform.position = cubeControlScript.transform.position + 2* Vector3.up + 1 * cubeControlScript.transform.forward;
        rb.velocity = 10 * (2 * Vector3.up + 3 * cubeControlScript.transform.forward);
  
    }
}
