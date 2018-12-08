using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitControl : MonoBehaviour {

    public void exitLevel()
    {
        SceneManager.LoadScene("Menu Principal");
    }

    public void fimdeLevel()
    {
        SceneManager.LoadScene("LevelConcluido");
    }
}
