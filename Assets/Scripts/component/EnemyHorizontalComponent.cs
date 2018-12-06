using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalComponent : MonoBehaviour {
    EnemyController enemyController;
    Rigidbody2D rb;
    public int movementSpeed;


	// Use this for initialization
	void Start () {
        enemyController = new EnemyController();
        rb = GetComponent<Rigidbody2D>();
        enemyController.setMovementSpeed(movementSpeed);
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(enemyController.getMovementSpeed(), rb.velocity.y);
        if (enemyController.isCollide()) {
            flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemyCollider")) {
            enemyController.setCollide(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemyCollider")) {
            enemyController.setCollide(false);
        }
    }

    private void flip()
    {
        GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
        enemyController.setMovementSpeed(enemyController.getMovementSpeed() * -1);
        enemyController.setCollide(false);
    }
}
