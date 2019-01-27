﻿using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameObject player;
    private PlayerStats pl_stats;
    public GameObject PauseCanvas;
    //public GameObject MainCanvas;
    public int tempo = 1;
    // Start is called before the first frame update
    

    void Awake(){
        StartCoroutine("Wait");
    }
    void Start()
    {
        player = GameObject.Find("Player");
        pl_stats = player.transform.GetComponent<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // aperta espaço para pausar o jogo
        {
            if (Time.timeScale == 0f)
            {
                PauseCanvas.SetActive(false);
                //MainCanvas.SetActive(true);
                Time.timeScale=1f;

            }
            else
            {
                //MainCanvas.SetActive(false);
                PauseCanvas.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.E)) // aperta espaço para pausar o jogo
        {
            StopCoroutine("Wait");
            Debug.Log("Parou coroutina");
        }

        if (pl_stats.vivo == false)
        {
            perdeu();
        }
        if (pl_stats.win == true)
        {
            ganhou();
        }
    }

    public void ganhou()
    {
        Debug.Log("ganhou");
    }
    public void perdeu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("StartMenu");
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(tempo);
        SanityDecrease();
    }

    public void SanityDecrease(){
        Debug.Log(pl_stats.sanity);
        pl_stats.sanity--;
        StartCoroutine("Wait");
    }

    public void safezone(bool var){
        if(var == true){
            StopCoroutine("Wait");
            Debug.Log("Parou coroutina");
        }
        else{
            StartCoroutine("Wait");
            Debug.Log("Recomecou corourtina");
        }
        while(pl_stats.sanity < 100){
            pl_stats.sanity++;
        }
    }


}
