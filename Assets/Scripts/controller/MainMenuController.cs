using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController: MonoBehaviour {
	public void startNewGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void closeGame()
    {
        Application.Quit();
    }
}
