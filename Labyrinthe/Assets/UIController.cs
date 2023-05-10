using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UIController : MonoBehaviour
{
    public TextMeshProUGUI cherryText;

    int amoutOfCherries = 9;

    // Start is called before the first frame updateW
    void Start()
    {
        cherryText.text = "Cerises restantes: " + amoutOfCherries.ToString();
        CherryController.collectCherry += collectCherry;
    }

    // Update is called once per frame
    void Update()
    {
        if (amoutOfCherries == 0)
        {
            SceneManager.LoadScene("MenuJeu", LoadSceneMode.Single);

        }
        
    }

    private void collectCherry()
    {
        amoutOfCherries--;
        cherryText.text = "Cerises restantes: " + amoutOfCherries.ToString();
        print(amoutOfCherries);
    }
}
