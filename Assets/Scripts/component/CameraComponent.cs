using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraComponent : MonoBehaviour {
    CameraController controller;
	// Use this for initialization
	void Start () {
        controller = new CameraController();
	}
	
	// Update is called once per frame
	void Update () {
        controller.followPlayer(GetComponent<Transform>(), GameObject.Find("Player").GetComponent<Transform>());
	}
}
