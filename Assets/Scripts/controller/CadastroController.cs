using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CadastroController : MonoBehaviour {
    private Usuarios_DBMock db;

    public void signUp()
    {
        db = Usuarios_DBMock.getInstance();
        string name = GameObject.Find("txtName").GetComponent<TMP_Text>().text;
        string username = GameObject.Find("txtUsername").GetComponent<TMP_Text>().text;
        string nickname = GameObject.Find("txtNickname").GetComponent<TMP_Text>().text;
        string email = GameObject.Find("txtEmail").GetComponent<TMP_Text>().text;
        string email2 = GameObject.Find("txtEmail2").GetComponent<TMP_Text>().text;
        string password = GameObject.Find("InpuSenha").GetComponent<TMP_InputField>().text;
        string password2 = GameObject.Find("InpuSenhaConf").GetComponent<TMP_InputField>().text;

        // fix nos campos para usar comparação
        char[] fixName = name.ToCharArray();
        fixName[fixName.Length - 1] = '\0';
        name = fixName.ArrayToString();

        char[] fixUsername = username.ToCharArray();
        fixUsername[fixUsername.Length - 1] = '\0';
        username = fixUsername.ArrayToString();

        char[] fixNickname = nickname.ToCharArray();
        fixNickname[fixNickname.Length - 1] = '\0';
        nickname = fixNickname.ArrayToString();

        char[] fixEmail = email.ToCharArray();
        fixEmail[fixEmail.Length - 1] = '\0';
        email = fixEmail.ArrayToString();

        char[] fixEmail2 = email2.ToCharArray();
        fixEmail2[fixEmail2.Length - 1] = '\0';
        email2 = fixEmail2.ArrayToString();

        if(email.Equals(email2) && password.Equals(password2) 
            && !name.Trim().Equals("") && !username.Trim().Equals("") && !nickname.Trim().Equals("") 
            && !email.Trim().Equals("") && !email2.Trim().Equals("") && !password.Trim().Equals("") && !password2.Trim().Equals("")) {
            db.addUser(name, username, nickname, password, email, 0);
            SceneManager.LoadScene("TelaLogin");
        } else {
            GameObject.Find("tituloCdastro").GetComponent<TMP_Text>().text = "Preencha corretamente os campos!";
        }
        
    }

    public void returnToLoginScreen()
    {
        SceneManager.LoadScene("TelaLogin");
    }

}
