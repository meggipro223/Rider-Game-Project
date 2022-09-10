using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControllerScript : MonoBehaviour {

    private string SceneName = "Main";

	public void PlayBtn()
    {
        SceneManager.LoadScene(SceneName);
    }

    public void ExitBtn()
    {
        Application.Quit();
    }
}
