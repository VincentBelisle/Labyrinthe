using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI cherryController;

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
        cherryController.text = amoutOfCherries.ToString();
        print(amoutOfCherries);
    }
}
