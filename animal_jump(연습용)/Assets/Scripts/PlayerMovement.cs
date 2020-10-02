using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody myrigidbody;
    public bool jump = false;
    public bool doublejump = false;
    public Transform pos;
    public float checkRadius;
    public LayerMask islayer;
    public bool isGround;
    public object player;

    // Start is called before the first frame update
    void Start()
    {
       // myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(transform.position.x + 2.5f, transform.position.y + 5f, 0);
        Vector3 target1 = new Vector3(transform.position.x + 1.5f, transform.position.y + 2f, 0);


        if (jump && (isGround == true))
        {
            transform.position = Vector3.Slerp(target1, transform.position, 0.1f);
        }

        if (doublejump && (isGround == true))
        {
            transform.position = Vector3.Slerp(target, transform.position, 0.3f);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;
        if (other.CompareTag("Ground"))
        {
            isGround = true;
        }
    }


}
