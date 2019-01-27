using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
	public void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log("ping");
        SceneManager.LoadScene("Ending");
        //SceneManager.LoadScene("Final");
    }
}
