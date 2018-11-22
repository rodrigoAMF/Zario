using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private int forcaPulo;
    private float movimento;
    private float velocidadeMaxima; 
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        forcaPulo = 200;
        velocidadeMaxima = 2;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        movimento = Input.GetAxis("Horizontal") * velocidadeMaxima;
        rb.velocity = new Vector2(movimento, rb.velocity.y);
        if(movimento >= 0){
            GetComponent<SpriteRenderer>().flipX = false;
        }else{
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,forcaPulo));
        }
    }
}
