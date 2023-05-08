using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject instructions;
    public GameObject mainMenu;
    public GameObject optionsMenu;	
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Level_01", LoadSceneMode.Single);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ShowInstructions()
    {
        instructions.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void HideInstructions()
    {
        instructions.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void ShowOptions()
    {
        optionsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }
    public void HideOptions()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void MuteAudio(bool isMuted)
    {
        AudioListener.volume = isMuted ? 1 : 0;
    }
    
}
