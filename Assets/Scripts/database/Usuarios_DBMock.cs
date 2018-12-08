using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usuarios_DBMock{
    private static Usuarios_DBMock instance;

    private int idAtual;
    private List<int> id;
    private List<string> name;
    private List<string> username;
    private List<string> nickname;
    private List<string> password;
    private List<string> email;
    private List<int> userType;

    public static Usuarios_DBMock getInstance()
    {
        if(instance == null) {
            instance = new Usuarios_DBMock();
        }
        return instance;
    }

    public Usuarios_DBMock()
    {
        idAtual = 0;
        id = new List<int>();
        name = new List<string>();
        username = new List<string>();
        nickname = new List<string>();
        password = new List<string>();
        email = new List<string>();
        userType = new List<int>();
        addUser("Rodrigo A. M. Franco", "rodrigoamf7", "Zolus", "123", "rodrigoamf@email.com", 0);
        addUser("Luziane Freitas", "luhfreitas", "luluzinha", "123", "luziane@email.com", 0);
    }

    public void addUser(string name, string username, string nickname, string password, string email, int userType)
    {
        id.Add(idAtual++);
        this.name.Add(name);
        this.username.Add(username);
        this.nickname.Add(nickname);
        this.password.Add(password);
        this.email.Add(email);
        this.userType.Add(userType);
    }

    public int getUserId(string username)
    {
        int id = -1;

        for (int i = 0; i < this.username.Count; i++) {
            if (string.Equals(this.username[i], username)) {
                id = this.id[i];
                break;
            }
        }

        return id;
    }

    public string getUserPassword(int id)
    {
        return password[id];
    }
}
