using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject PauseCanvas;
    //public GameObject MainCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
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

    }


}
