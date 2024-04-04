using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
public GameObject pauseMenu;
public static bool isPaused;

void Start()
	{
	pauseMenu.SetActive(false);
	isPaused = false;
	}
void Update()
	{
	if(Input.GetKeyDown(KeyCode.Escape))
	{
		if(isPaused)
		{
			ResumeGame();
		}
		else
		{
			PauseGame();
		}
	}
	}
public void PauseGame()
	{
	pauseMenu.SetActive(true);
	Time.timeScale = 0f;
	isPaused = true;
	Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
	}
public void ResumeGame()
	{
	pauseMenu.SetActive(false);
	Time.timeScale = 1f;
	isPaused = false;
	Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
	}
public void MainMenu()
	{
SceneManager.LoadScene("MainMenu");
Time.timeScale = 1f;
	}
public void QuitGame()
	{
	Application.Quit();
	}
}