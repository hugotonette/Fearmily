using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{
	public GameObject Credits1;
	public GameObject Credits2;
	public GameObject Credits3;
	public GameObject Credits4;

	public int Timer;

	IEnumerator FadeCoroutine()
	{
		yield return new WaitForSeconds(Timer);
		Credits1.SetActive(false);
		Credits2.SetActive(true);
		yield return new WaitForSeconds(Timer);
		Credits2.SetActive(false);
		Credits3.SetActive(true);
		yield return new WaitForSeconds(Timer);
		Credits3.SetActive(false);
		Credits4.SetActive(true);
		yield return new WaitForSeconds(Timer);
		SceneManager.LoadScene("Final");
	}

	private void Start()
	{
		StartCoroutine(FadeCoroutine());
	}

	/*
	private bool _credit1In = false;
	private bool _credit2In = false;
	private bool _credit3In = false;
	private bool _credit4In = false;

	private bool _credit1Out = false;
	private bool _credit2Out = false;
	private bool _credit3Out = false;
	private bool _credit4Out = false;
	
	IEnumerator FadeIn()
	{
		Credits1.SetActive(true);
		_credit1In = true;
		yield return new WaitForSeconds(Timer);
		_credit1In = false;
		_credit1Out = true;
		yield return new WaitForSeconds(Timer);
		_credit1Out = false;
		Credits1.SetActive(false);

		Credits2.SetActive(true);
		_credit2In = true;
		yield return new WaitForSeconds(Timer);
		_credit2In = false;
		_credit2Out = true;
		yield return new WaitForSeconds(Timer);
		_credit2Out = false;
		Credits2.SetActive(false);

		Credits3.SetActive(true);
		_credit3In = true;
		yield return new WaitForSeconds(Timer);
		_credit3In = false;
		_credit3Out = true;
		yield return new WaitForSeconds(Timer);
		_credit3Out = false;
		Credits3.SetActive(false);

		Credits4.SetActive(true);
		_credit4In = true;
		yield return new WaitForSeconds(Timer);
		_credit4In = false;
		_credit4Out = true;
		yield return new WaitForSeconds(Timer);
		_credit4Out = false;
		Credits4.SetActive(false);
	}

	private void Start()
	{
		StartCoroutine(FadeIn());
	}

	private void FixedUpdate()
	{
		if (_credit1In)
		{
			Image tImage = Credits1.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a + (5 / 300);
			tImage.color = c;
		}
		if (_credit1Out)
		{
			Image tImage = Credits1.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a - (5 / 300);
			tImage.color = c;
		}
		if (_credit2In)
		{
			Image tImage = Credits2.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a + (5 / 300);
			tImage.color = c;
		}
		if (_credit2Out)
		{
			Image tImage = Credits2.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a - (5 / 300);
			tImage.color = c;
		}
		if (_credit3In)
		{
			Image tImage = Credits3.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a + (5 / 300);
			tImage.color = c;
		}
		if (_credit3Out)
		{
			Image tImage = Credits3.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a - (5 / 300);
			tImage.color = c;
		}
		if (_credit4In)
		{
			Image tImage = Credits4.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a + (5 / 300);
			tImage.color = c;
		}
		if (_credit4Out)
		{
			Image tImage = Credits4.gameObject.GetComponent<Image>();
			Color c = tImage.color;
			c.a = c.a - (5 / 300);
			tImage.color = c;
		}
	}
	*/
}
