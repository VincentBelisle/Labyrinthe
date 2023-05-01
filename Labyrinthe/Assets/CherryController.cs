using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ChompSlayer")
        {
            Destroy(gameObject, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
