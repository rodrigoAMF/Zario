using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    private int forcaPulo;
    private float movimento;
    private int moedas;
    private float velocidadeMaxima;
    private bool estaNoChao;
    private int vidaAtual;
    private int numeroVidas;

    private double tamanhoMaxBarraVida;
    private double tamanhoMaxBarraForca;

    private Rigidbody2D rb;
    private Animator animator;
    public Text lblNumeroMoedas;
    public Text lblNumeroVidas;
    public GameObject barraVidaAtual;

	// Use this for initialization
	void Start () {
        tamanhoMaxBarraVida = 21;
        tamanhoMaxBarraForca = 21;
        forcaPulo = 200;
        velocidadeMaxima = 2;
        moedas = 0;
        numeroVidas = 3;
        vidaAtual = 100;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        lblNumeroVidas.text = numeroVidas.ToString();
        GetComponent<Transform>().position = GameObject.Find("LevelBegin").GetComponent<Transform>().position;
    }
	
	// Update is called once per frame
	void Update () {
        movimento = Input.GetAxis("Horizontal") * velocidadeMaxima;
        // Habilita a animação de correr e aumenta velocidade do jogador
        if (Input.GetKey(KeyCode.LeftShift)) {
            movimento *= 2;
            animator.SetBool("running", true);
        } else {
            animator.SetBool("running", false);
        }

        // movimenta o jogador e habilita animação de movimentação
        rb.velocity = new Vector2(movimento, rb.velocity.y);
        if(movimento > 0 || movimento < 0) {
            animator.SetBool("walking", true);
        } else {
            animator.SetBool("walking", false);
        }
        // efetua flip na sprite em contraste ao movimento
        if(movimento >= 0){
            GetComponent<SpriteRenderer>().flipX = false;
        }else{
            GetComponent<SpriteRenderer>().flipX = true;
        }
        // efetuando pulo
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,forcaPulo));
        }
        // adiciona animação de pulo
        if (estaNoChao) {
            animator.SetBool("jumping", false);
        } else {
            animator.SetBool("jumping", true);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Moeda")) {
            Destroy(collision.gameObject);
            moedas++;
            lblNumeroMoedas.text = moedas.ToString();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataformas")){
            estaNoChao = true;
        }
        if (collision.gameObject.CompareTag("Enemy")) {
            vidaAtual -= 20;
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-500, 500));
            Vector3 tamanhoAtual = barraVidaAtual.GetComponent<Transform>().localScale;
            Vector3 novoTamanho = new Vector3((float)(tamanhoMaxBarraVida * (vidaAtual / 100.0)), tamanhoAtual.y, tamanhoAtual.z);
            barraVidaAtual.GetComponent<Transform>().localScale = novoTamanho;
            if (vidaAtual <= 0) {
                numeroVidas--;
                lblNumeroVidas.text = numeroVidas.ToString();
                moedas = 0;
                lblNumeroMoedas.text = moedas.ToString();
                vidaAtual = 100;
                barraVidaAtual.GetComponent<Transform>().localScale = new Vector3((float)tamanhoMaxBarraVida, tamanhoAtual.y, tamanhoAtual.z);
                GetComponent<Transform>().position = GameObject.Find("LevelBegin").GetComponent<Transform>().position;
                if (numeroVidas == 0) {
                    // Game Over
                }
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataformas")) {
            estaNoChao = false;
        }
    }
}
