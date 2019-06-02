using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UniRx;

public class LoadSceneManager : MonoBehaviour
{
	[SerializeField]
	Button StartButton;
	[SerializeField]
	Button ExittButton;



	void Start()
	{
		OnButtonDown();
	}


	void OnButtonDown()
	{
		StartButton.onClick.AsObservable().Subscribe(_ => SceneManager.LoadScene("main"));
		ExittButton.onClick.AsObservable().Subscribe(x => Application.Quit());

	}
}
