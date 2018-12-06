using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour {

	public void iniciarNovoJogo()
    {
        Debug.Log("Mudou cena");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void sair()
    {
        Debug.Log("Sair");
        Application.Quit();
    }
}
