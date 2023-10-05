using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
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

    private void OnCollisionEnter(Collision collision)
    {
        print("Ouch");
        
       // DealWithHits thingIHite = collision.gameObject.GetComponent<DealWithHits>();
        //if (thingIHite != null)
       // {
        //    thingIHite.IHitYou();

      //  }
    }

    internal void ImThrowingYou(CubeControlScript cubeControlScript)
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, (float)0.2, (float)-0.1);
        transform.position = cubeControlScript.transform.position + 2* Vector3.up + 1 * cubeControlScript.transform.forward;
        rb.velocity = 10 * (2 * Vector3.up + 3 * cubeControlScript.transform.forward);
  
    }
}

internal class DealWithHits
{
    //int Health = 100;
    //internal void IHitYou()
    //{
      //  Health -= 20;
        //throw new NotImplementedException();

       // if (Health < 0 )
        //{
          // Destroy(this.gameObject);
                
       // }
      
   // }
}