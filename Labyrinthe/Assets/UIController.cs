using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIController : MonoBehaviour
{

    public TextMeshProUGUI cherryController;

    int amoutOfCherries = 9; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CollectCherry()
    {
        amoutOfCherries--;
        cherryController.text = amoutOfCherries.ToString();
    }
}
