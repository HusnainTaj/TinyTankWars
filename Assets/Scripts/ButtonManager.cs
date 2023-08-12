using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour 
{
	public void PlayBtn()
	{
		SceneManager.LoadScene (3);
	}
	public void RestartBtn()
	{
		SceneManager.LoadScene (3);
	}
	public void MainMenuBtn()
	{
		SceneManager.LoadScene (1);
	}
	public void InstructionBtn()
	{
		SceneManager.LoadScene (2);
	}
	public void Credits()
	{
		SceneManager.LoadScene (6);
	}
}
