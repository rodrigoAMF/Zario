using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerComponent : MonoBehaviour {
    //private PlayerModel player;
    private PlayerController playerController;

    // Game Objects
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer sp;
    public Text lblNumeroMoedas;
    public Text lblNumeroVidas;
    public GameObject barraVidaAtual;


    // Use this for initialization
    void Start () {
        playerController = new PlayerController();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
        lblNumeroVidas.text = playerController.getNumeroVidas().ToString();
        transform.position = GameObject.Find("LevelBegin").GetComponent<Transform>().position;
    }
	
	// Update is called once per frame
	void Update () {
        playerController.setVelocidadeMovimentoAtual(Input.GetAxis("Horizontal") * playerController.getVelocidadeMaxima());

        verifyIfIsDead();

        verifyIfIsRunning();

        movePlayer();

        verifyIfIsJumping();

        verifyIfIsAttacking();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Level_End")) {
            SceneManager.LoadScene("LevelConcluido");
        }
        if (collision.gameObject.CompareTag("Moeda")) {
            Destroy(collision.gameObject);
            playerController.setNumeroMoedas(playerController.getNumeroMoedas()+1);
            lblNumeroMoedas.text = playerController.getNumeroMoedas().ToString();
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataformas") || collision.gameObject.CompareTag("Caixa") || collision.gameObject.CompareTag("Pedras")) {
            playerController.setEstaNoChao(true);
        }
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Agua")) {
            playerDead();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Plataformas")) {
            playerController.setEstaNoChao(false);
        }
    }

    private void verifyIfIsRunning()
    {
        // Habilita a animação de correr e aumenta velocidade do jogador
        if (Input.GetKey(KeyCode.LeftShift)) {
            playerController.setVelocidadeMovimentoAtual(playerController.getVelocidadeMovimentoAtual() * 2);
            animator.SetBool("running", true);
        } else {
            animator.SetBool("running", false);
        }
    }

    private void verifyIfIsDead()
    {
        if(transform.position.y < (-1)) {
            playerDead();
        }
    }

    private void playerDead()
    {
        playerController.setNumeroVidas(playerController.getNumeroVidas() - 1);
        lblNumeroVidas.text = playerController.getNumeroVidas().ToString();
        playerController.setNumeroMoedas(0);
        lblNumeroMoedas.text = playerController.getNumeroMoedas().ToString();
        GetComponent<Transform>().position = GameObject.Find("LevelBegin").GetComponent<Transform>().position;
        if (playerController.getNumeroVidas() == 0) {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void movePlayer()
    {
        // movimenta o jogador e habilita animação de movimentação
        rb.velocity = new Vector2(playerController.getVelocidadeMovimentoAtual(), rb.velocity.y);
        if (playerController.getVelocidadeMovimentoAtual() > 0 || playerController.getVelocidadeMovimentoAtual() < 0) {
            animator.SetBool("walking", true);
        } else {
            animator.SetBool("walking", false);
        }
        // efetua flip na sprite em contraste ao movimento
        if (playerController.getVelocidadeMovimentoAtual() >= 0) {
            sp.flipX = false;
        } else {
            sp.flipX = true;
        }
    }
    public void verifyIfIsJumping()
    {
        // efetuando pulo
        if (Input.GetKeyDown(KeyCode.Space) && playerController.isEstaNoChao()) {
            rb.AddForce(new Vector2(0, playerController.getForcaPulo()));
        } else if (Input.GetKeyDown(KeyCode.Space) && !playerController.isEstaNoChao() && !playerController.isDoubleJump()) {
            rb.AddForce(new Vector2(0, playerController.getForcaPulo()));
            playerController.setDoubleJump(true);
        }
        // adiciona animação de pulo
        if (playerController.isEstaNoChao()) {
            playerController.setDoubleJump(false);
            animator.SetBool("jumping", false);
        } else {
            animator.SetBool("jumping", true);
        }
    }

    public void verifyIfIsAttacking()
    {
        if (Input.GetKeyDown(KeyCode.P)) {
            animator.SetTrigger("attack");

            /*audio.clip = spinSound;
            audio.Play();*/
            Collider2D myCollider = GameObject.Find("attackArea").GetComponent<Collider2D>();
            int numColliders = 10;
            Collider2D[] colliders = new Collider2D[numColliders];
            ContactFilter2D contactFilter = new ContactFilter2D();
            // Set you filters here according to https://docs.unity3d.com/ScriptReference/ContactFilter2D.html
            int colliderCount = myCollider.OverlapCollider(contactFilter, colliders);
            for (int i = 0; i < 100000; i++) ;
            for (int i = 0; i < colliderCount; i++) {
                if (colliders[i].gameObject.tag == "Enemy") {
                    Destroy(colliders[i].gameObject);
                }
            }
        }
    }
}
