using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    public GameObject snowballclonetemplate;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody myRB;

        myRB = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.W))
        {


            myRB.AddForce(transform.forward);

            // transform.position += transform.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            myRB.AddExplosionForce(10, transform.position + Vector3.down, 5);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -90 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, 90 * Time.deltaTime);
    
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject newGO = Instantiate(snowballclonetemplate);

            Snowballcontrolscript mySnowball = newGO.GetComponent<Snowballcontrolscript>();

            mySnowball.ImThrowingYou(this);
        }

    }

}