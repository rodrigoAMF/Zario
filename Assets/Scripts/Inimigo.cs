using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {

    private float mov = -2;
    Rigidbody2D rb;
    private bool checarChao = false;
    Transform chao;


    // Use this for initialization
    void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        chao = transform.Find("CheckGround");
    }

    void Update()
    {
        /*checarChao = Physics2D.Linecast(transform.position, 1 << LayerMask.NameToLayer("Ground"));
        //GetComponent<Rigidbody2D>().velocity = new Vector2(mov, GetComponent<Rigidbody2D>().velocity.y);
        checarChao = true;*/
        if (!checarChao)
        {
            mov *= 1;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(mov, GetComponent<Rigidbody2D>().velocity.y);

        if(mov > 0)
        {
            Flip();
        }
        else if (mov < 0)
        {
            Flip();
        }
    }

    private void Flip()
    {
        mov *= -1;
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        checarChao = false;
    }

}
