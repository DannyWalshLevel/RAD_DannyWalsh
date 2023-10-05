using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using UnityEngine;

public class lava : MonoBehaviour
{
    
    GameObject Player;
   
    

            // Start is called before the first frame update
            void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
     {
        if (collision.gameObject.tag.Equals("Player"))
        {"Player"
        }
      
      
     }
}
