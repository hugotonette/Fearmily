using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    public GameObject PauseCanvas;
    //public GameObject MainCanvas;
    [HideInInspector]
    public static bool iniciouGame;

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

    public void PlayGame()
    {
        Time.timeScale = 1f;
        PauseCanvas.SetActive(false);
        //MainCanvas.SetActive(true);

    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

}
