using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoginController : MonoBehaviour {
    private Usuarios_DBMock db;

    public void authenticate()
    {
        db = Usuarios_DBMock.getInstance();
        string username = GameObject.Find("txtLogin").GetComponent<TMP_Text>().text;
        string password = GameObject.Find("InpuSenha").GetComponent<TMP_InputField>().text;

        char[] fixUsername = username.ToCharArray();
        fixUsername[fixUsername.Length-1] = '\0';
        username = fixUsername.ArrayToString();

        int id = db.getUserId(username);
        
        if (id != -1 && db.getUserPassword(id) == password) {
            loadMainMenu();
        } else {
            GameObject.Find("txtMensagem").GetComponent<TMP_Text>().text = "Erro na Autenticação";
        }
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene("Menu Principal");
    }
}
