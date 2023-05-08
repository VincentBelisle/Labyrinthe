using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CherryController : MonoBehaviour
{
    public AudioSource audioSource;
    public static event Action collectCherry;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ChompSlayer")
        {
            audioSource.Play();
            collectCherry?.Invoke();
            Destroy(gameObject, 1f);
        }
    }
}
