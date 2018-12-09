using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour {
    public void playAgain()
    {
        SceneManager.LoadScene("Level1");
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene("Menu Principal");
    }
	
}
