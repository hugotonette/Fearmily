using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject MenuCanvas;
    public GameObject SettingsCanvas;
    public static MainMenu instance;

    private void Awake()
    {
    }

    void Start()
    {
    }
    // Update is called once per frame
    void Update () {
		
	}

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void restart()
    {
        PlayGame();
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void SettingsGame()
    {
        SettingsCanvas.SetActive(true);
        MenuCanvas.SetActive(false);
    }

    public void GoToMainMenu()
    {
        MenuCanvas.SetActive(true);
    }

    public void LoadCredits()
    {
        SceneManager.LoadScene("creditos");
    }
}
