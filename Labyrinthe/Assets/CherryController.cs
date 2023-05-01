using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public AudioSource audioSource;
    
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
            Destroy(gameObject, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
