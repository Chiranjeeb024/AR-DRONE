using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemng : MonoBehaviour
{
	// Start is called before the first frame update

	public void ChangeScene(string scene1)
	{
		SceneManager.LoadScene("SampleScene");
	}

	public void ChangeScene2(string scene2)
	{
		SceneManager.LoadScene("UI");
	}

	public void ChangeScene3(string scene3)
	{
		SceneManager.LoadScene("UI2");
	}

	public void ChangeScene4(string scene4)
	{
		SceneManager.LoadScene("DRONE2");
	}

	public void ChangeScene5(string scene5)
	{
		SceneManager.LoadScene("INFO");
	}

	public void Exit()
	{
		Application.Quit();
	}
}
