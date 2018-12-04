using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    private int numeroVidas;
    private int forcaPulo;
    private float movimento;
    private int moedas;
    private float velocidadeMaxima;
    private bool estaNoChao;
    private Rigidbody2D rb;
    private Animator animator;
    public Text lblNumeroMoedas;
    public Text lblNumeroVidas;

	// Use this for initialization
	void Start () {
        forcaPulo = 200;
        velocidadeMaxima = 2;
        moedas = 0;
        numeroVidas = 3;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        lblNumeroVidas.text = numeroVidas.ToString();
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
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataformas")) {
            estaNoChao = false;
        }
    }
}
