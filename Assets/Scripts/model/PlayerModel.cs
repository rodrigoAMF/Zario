using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerModel
{
    // BD
    private string username;
    private string nickname;
    private int score;
    private bool gameMaster;
    // Jogo
    private int vidaAtual;
    private int numeroVidas;
    private int forcaPulo;
    private bool estaNoChao;
    private bool doubleJump;
    private float velocidadeMovimentoAtual;
    private float velocidadeMaxima;
    private int numeroMoedas;
    private double tamanhoMaxBarraVida;

    public PlayerModel()
    {
        gameMaster = false;
        vidaAtual = 100;
        numeroVidas = 3;
        forcaPulo = 300;
        estaNoChao = true;
        doubleJump = false;
        velocidadeMaxima = 2;
        numeroMoedas = 0;
        tamanhoMaxBarraVida = 21;
    }

    public string getUsername()
    {
        return username;
    }
    public void setUsername(string username)
    {
        this.username = username;
    }
    public string getNickname()
    {
        return nickname;
    }
    public void setNickname(string nickname)
    {
        this.nickname = nickname;
    }
    public int getScore()
    {
        return score;
    }
    public void setScore(int score)
    {
        this.score = score;
    }
    public bool isGameMaster()
    {
        return gameMaster;
    }
    public void setGameMaster(bool gameMaster)
    {
        this.gameMaster = gameMaster;
    }
    public int getVidaAtual()
    {
        return vidaAtual;
    }
    public void setVidaAtual(int vidaAtual)
    {
        this.vidaAtual = vidaAtual;
    }
    public int getNumeroVidas()
    {
        return numeroVidas;
    }
    public void setNumeroVidas(int numeroVidas)
    {
        this.numeroVidas = numeroVidas;
    }
    public int getForcaPulo()
    {
        return forcaPulo;
    }
    public void setForcaPulo(int forcaPulo)
    {
        this.forcaPulo = forcaPulo;
    }
    public bool isEstaNoChao()
    {
        return estaNoChao;
    }
    public void setEstaNoChao(bool estaNoChao)
    {
        this.estaNoChao = estaNoChao;
    }
    public bool isDoubleJump()
    {
        return doubleJump;
    }
    public void setDoubleJump(bool doubleJump)
    {
        this.doubleJump = doubleJump;
    }
    public float getVelocidadeMovimentoAtual()
    {
        return velocidadeMovimentoAtual;
    }
    public void setVelocidadeMovimentoAtual(float velocidadeMovimentoAtual)
    {
        this.velocidadeMovimentoAtual = velocidadeMovimentoAtual;
    }
    public float getVelocidadeMaxima()
    {
        return velocidadeMaxima;
    }
    public void setVelocidadeMaxima(float velocidadeMaxima)
    {
        this.velocidadeMaxima = velocidadeMaxima;
    }
    public int getNumeroMoedas()
    {
        return numeroMoedas;
    }
    public void setNumeroMoedas(int numeroMoedas)
    {
        this.numeroMoedas = numeroMoedas;
    }
    public double getTamanhoMaxBarraVida()
    {
        return tamanhoMaxBarraVida;
    }
    public void setTamanhoMaxBarraVida(double tamanhoMaxBarraVida)
    {
        this.tamanhoMaxBarraVida = tamanhoMaxBarraVida;
    }

}
