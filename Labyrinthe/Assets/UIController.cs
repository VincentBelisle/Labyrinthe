using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI cherryText;

    int amoutOfCherries = 9;

    // Start is called before the first frame updateW
    void Start()
    {
        CherryController.collectCherry += collectCherry;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void collectCherry()
    {
        amoutOfCherries--;
        cherryText.text = "Cerises restantes: " + amoutOfCherries.ToString();
        print(amoutOfCherries);
    }
}
