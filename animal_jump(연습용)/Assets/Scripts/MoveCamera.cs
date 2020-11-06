using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public float speed=1.5f;

    GameObject platformparent;
    randomPlatform randomplatform;

    public Vector2 center;
    public Vector2 size;

    public Vector3 position;
    int i;

    void Start()
    {
        platformparent = GameObject.Find("PlatformParent");
        randomplatform = platformparent.GetComponent<randomPlatform>();
        
        position.x = -2.1f;
        position.y = -1.4f;
        position.z = -30;
    }

    void Update()
    {
        if(randomplatform.cam_start == true)
        {
            this.transform.Translate((new Vector3(2.27f, 1,0)*Time.deltaTime*speed));


        }
        
       
    }
}
