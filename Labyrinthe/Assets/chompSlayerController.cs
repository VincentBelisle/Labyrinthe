using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class chompSlayerController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("chompMan")){
            Debug.Log("you died");
            SceneManager.LoadScene("MenuJeu", LoadSceneMode.Single);

        }
    }
}
