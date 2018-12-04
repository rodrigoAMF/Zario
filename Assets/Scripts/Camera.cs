using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
    private Vector3 playerPosition;
    private Vector3 cameraPosition;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        playerPosition = GameObject.Find("Player").GetComponent<Transform>().position;
        cameraPosition = GetComponent<Transform>().position;
        cameraPosition.x = playerPosition.x + 2;
        cameraPosition.y = playerPosition.y + 1.4f;
        GetComponent<Transform>().position = cameraPosition;
    }
}
