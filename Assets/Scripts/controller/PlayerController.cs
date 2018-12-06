using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController {
    private PlayerModel playerModel;

    public PlayerController()
    {
        playerModel = new PlayerModel();
    }

    public string getUsername()
    {
        return playerModel.getUsername();
    }
    public void setUsername(string username)
    {
        playerModel.setUsername(username);
    }
    public string getNickname()
    {
        return playerModel.getNickname();
    }
    public void setNickname(string nickname)
    {
        playerModel.setNickname(nickname);
    }
    public int getScore()
    {
        return playerModel.getScore();
    }
    public void setScore(int score)
    {
        playerModel.setScore(score);
    }
    public bool isGameMaster()
    {
        return playerModel.isGameMaster();
    }
    public void setGameMaster(bool gameMaster)
    {
        playerModel.setGameMaster(gameMaster);
    }
    public int getVidaAtual()
    {
        return playerModel.getVidaAtual();
    }
    public void setVidaAtual(int vidaAtual)
    {
        playerModel.setVidaAtual(vidaAtual);
    }
    public int getNumeroVidas()
    {
        return playerModel.getNumeroVidas();
    }
    public void setNumeroVidas(int numeroVidas)
    {
        playerModel.setNumeroVidas(numeroVidas);
    }
    public int getForcaPulo()
    {
        return playerModel.getForcaPulo();
    }
    public void setForcaPulo(int forcaPulo)
    {
        playerModel.setForcaPulo(forcaPulo);
    }
    public bool isEstaNoChao()
    {
        return playerModel.isEstaNoChao();
    }
    public void setEstaNoChao(bool estaNoChao)
    {
        playerModel.setEstaNoChao(estaNoChao);
    }
    public bool isDoubleJump()
    {
        return playerModel.isDoubleJump();
    }
    public void setDoubleJump(bool doubleJump)
    {
        playerModel.setDoubleJump(doubleJump);
    }
    public float getVelocidadeMovimentoAtual()
    {
        return playerModel.getVelocidadeMovimentoAtual();
    }
    public void setVelocidadeMovimentoAtual(float velocidadeMovimentoAtual)
    {
        playerModel.setVelocidadeMovimentoAtual(velocidadeMovimentoAtual);
    }
    public float getVelocidadeMaxima()
    {
        return playerModel.getVelocidadeMaxima();
    }
    public void setVelocidadeMaxima(float velocidadeMaxima)
    {
        playerModel.setVelocidadeMaxima(velocidadeMaxima);
    }
    public int getNumeroMoedas()
    {
        return playerModel.getNumeroMoedas();
    }
    public void setNumeroMoedas(int numeroMoedas)
    {
        playerModel.setNumeroMoedas(numeroMoedas);
    }
    public double getTamanhoMaxBarraVida()
    {
        return playerModel.getTamanhoMaxBarraVida();
    }
    public void setTamanhoMaxBarraVida(double tamanhoMaxBarraVida)
    {
        playerModel.setTamanhoMaxBarraVida(tamanhoMaxBarraVida);
    }
}
