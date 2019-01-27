using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeText : MonoBehaviour
{
	public int Delay = 3;
	public float Speed = 1;
	public GameObject ButtonMainMenu;
	public Text ButtonText;

	private Image _textImage;
	private bool _canFade = false;
	private bool _canFadeBtn = false;

	IEnumerator FadeInText()
	{
		yield return new WaitForSeconds(Delay);
		_canFade = true;
		StartCoroutine(AppearButton());
	}

	IEnumerator AppearButton()
	{
		yield return new WaitForSeconds(5);
		ButtonMainMenu.SetActive(true);
		_canFadeBtn = true;
	}

	private void Start()
	{
		_textImage = this.gameObject.GetComponent<Image>();

		StartCoroutine(FadeInText());
	}

	private void FixedUpdate()
	{
		if (_canFade)
		{
			Color c = _textImage.color;
			c.a = c.a + (Speed / 300);
			_textImage.color = c;
		}

		if (_canFadeBtn)
		{
			Color bc = ButtonText.color;
			bc.a = bc.a + (Speed / 300);
			ButtonText.color = bc;
		}
	}

}
