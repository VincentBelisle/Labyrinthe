using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chompSlayerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("chompMan")){
            Debug.Log("you died");
            Destroy(collision.gameObject);
        }
    }
}
