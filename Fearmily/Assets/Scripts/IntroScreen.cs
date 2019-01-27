using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroScreen : MonoBehaviour
{
	public GameObject Intro1;
	public GameObject Intro2;
	public GameObject Intro3;
	public GameObject Tutorial;

	public int Timer = 5;

	IEnumerator FadeCoroutine()
	{
		yield return new WaitForSeconds(Timer);
		Intro1.SetActive(false);
		Intro2.SetActive(true);
		yield return new WaitForSeconds(Timer);
		Intro2.SetActive(false);
		Intro3.SetActive(true);
		yield return new WaitForSeconds(Timer);
		Intro3.SetActive(false);
		Tutorial.SetActive(true);
		yield return new WaitForSeconds(Timer * 2);
		SceneManager.LoadScene("Main");
	}

	private void Start()
	{
		StartCoroutine(FadeCoroutine());
	}
}
