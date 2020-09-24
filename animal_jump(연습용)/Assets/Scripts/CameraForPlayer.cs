using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraForPlayer : MonoBehaviour
{
    public GameObject player;

    public float offsetX = 2f;
    public float offsetY = 0f;
    public float offsetZ = -10f;

    Vector3 cameraPosition;

    private void LateUpdate()
    {
        cameraPosition.x = player.transform.position.x + offsetX;
        cameraPosition.y = player.transform.position.y + offsetY;
        cameraPosition.z = player.transform.position.z + offsetZ;

        transform.position = cameraPosition;

    }
}
