using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private int forcaPulo;
    private float movimento;
    private int moedas;
    private float velocidadeMaxima;
    private bool estaNoChao;
    private Rigidbody2D rb;
    private Animator animator;
	// Use this for initialization
	void Start () {
        forcaPulo = 200;
        velocidadeMaxima = 2;
        moedas = 0;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        movimento = Input.GetAxis("Horizontal") * velocidadeMaxima;
        if (Input.GetKey(KeyCode.LeftShift)) {
            movimento *= 2;
            animator.SetBool("running", true);
        } else {
            animator.SetBool("running", false);
        }

        rb.velocity = new Vector2(movimento, rb.velocity.y);
        if(movimento > 0 || movimento < 0) {
            animator.SetBool("walking", true);
        } else {
            animator.SetBool("walking", false);
        }
        if(movimento >= 0){
            GetComponent<SpriteRenderer>().flipX = false;
        }else{
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space) && estaNoChao){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,forcaPulo));
        }
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
