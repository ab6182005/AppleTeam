using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Jumping : MonoBehaviour
{
    
    Vector3 DestPos;
    Vector3 StartPos = new Vector3(-2, -0.3f, 0);

    float vx;
    float vy;
    float g;

    float dat;
    float mh;
    float dh;
    float t = 1.0f;
    float MAX_Y = 3.0f;
    float mht = 0.52f;  // 뛰는 거리 얘로 조절

    public Rigidbody myrigidbody;

    //public float jumpTime;
    //public float nowTime;

    public float jumpingSpeed1 = 0.45f;
    public float jumpingSpeed2 = 0.67f;

    /*
    public Transform startPos;
    public Transform destPos;

    public float journeyTime = 3.0f;
    private float startTime;
    */
    //public Vector3 startPos = new Vector3(-2, -0.3f, 0);
    //public Vector3 destPos = new Vector3(-1, -0.3f, 0);

    //public GameObject targetPosition;

    /*
    private void Start()
    {
        startTime = Time.time;
    }
    */
    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonUp(0))
        {
            //nowTime = Time.time;
            //Debug.Log(Time.time - jumpTime + "초 (클릭시간)");
            myrigidbody.velocity = Vector2.up * jumpingSpeed1 * 10;
            myrigidbody.velocity = new Vector2(jumpingSpeed1 * 110 * Time.fixedDeltaTime, myrigidbody.velocity.y);
        }
        if (Input.GetMouseButtonUp(1))
        {
            //nowTime = Time.time;
            //Debug.Log(Time.time - jumpTime + "초 (클릭시간)");
            myrigidbody.velocity = Vector2.up * jumpingSpeed2 * 10;
            myrigidbody.velocity = new Vector2(jumpingSpeed2 * 110 * Time.fixedDeltaTime, myrigidbody.velocity.y);
        }
    }
 
    
}
