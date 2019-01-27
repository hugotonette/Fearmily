using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Player")
		{
			Debug.Log("ping");
			SceneManager.LoadScene("Final");
		}
	}
}
