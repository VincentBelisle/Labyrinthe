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
        AudioListener.pause = PlayerPrefs.GetInt("Muted") == 1;
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
        PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);
    }
    public void SetEasy(bool easy)
    {
        PlayerPrefs.SetFloat("ChompSpeed", easy ? 0.5f : 1);

    }
    
}
