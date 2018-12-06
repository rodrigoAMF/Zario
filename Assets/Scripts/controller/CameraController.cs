using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController {
    private Vector3 playerPosition;
    private Vector3 cameraPosition;

    public void followPlayer(Transform cameraTransform, Transform playerTransform)
    {
        playerPosition = playerTransform.position;
        cameraPosition = cameraTransform.position;
        cameraPosition.x = playerPosition.x + 2;
        cameraPosition.y = playerPosition.y + 1.4f;
        cameraTransform.position = cameraPosition;
    }
}
