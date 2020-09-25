using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public float speed;

    public Vector2 center;
    public Vector2 size;

    public Vector3 position;

   
    void Start()
    {
       
    }

    void Update()
    {
        position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        transform.position = new Vector3(position.x, transform.position.y, -20f);
       
    }
}
