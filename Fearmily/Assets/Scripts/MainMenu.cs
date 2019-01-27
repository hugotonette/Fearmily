using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public GameObject MenuCanvas;
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
        SceneManager.LoadScene("final");
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
