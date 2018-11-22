using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var x = Input.GetAxis("Horizontal") *0.1;

        if(x > 0)
        {
            transform.Translate(transform.position.x + x, 0, 0);
        }

        
    }
}
