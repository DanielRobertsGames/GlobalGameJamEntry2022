using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
	public static bool GameIsPaused = false;
	public GameObject PauseMenuUI;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			if (GameIsPaused)
			{
				Resume();
			}
			else
			{
				Pause();
			}
		}
	}

	private void Pause()
	{
		PauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = false;
	}

	private void Resume()
	{
		PauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		GameIsPaused = true;
	}
	public void ResumeButton()
	{
		Resume();
	}
	public void ReturnMainMenu()
	{
		SceneManager.LoadScene(0);
	}
}
