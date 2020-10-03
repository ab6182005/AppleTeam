using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public bool jump = false;
    public bool doublejump = false;
    public Transform pos;
    public Transform Target;
    public float checkRadius;
    public LayerMask islayer;
    public bool isGround;
    public object player;
    int i;
    

    GameObject platformparent;
   
    randomPlatform randomplatform;
    
    

  
    // Start is called before the first frame update
    void Start()
    {
        platformparent = GameObject.Find("PlatformParent");
        randomplatform = platformparent.GetComponent<randomPlatform>();
        
        // myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        i = randomplatform.i;
        Rigidbody bodys = platformparent.transform.GetChild(i).gameObject.GetComponent<Rigidbody>();
        GameObject ChildGameObject0 = platformparent.transform.GetChild(i+1).gameObject;
        GameObject ChildGameObject1 = ChildGameObject0.transform.Find("GameObject").gameObject;

        Vector3 target = ChildGameObject1.transform.position;
        //Vector3 target = new Vector3(transform.position.x + 1.0f, transform.position.y + 1f, 0);
        //Vector3 target1 = new Vector3(transform.position.x + 0.5f, transform.position.y + 1f, 0);


        if (jump && (isGround == true))
        {
            transform.position = Vector3.Slerp(target, transform.position, 0.1f);
            bodys.useGravity = true;
        }

        if (doublejump && (isGround == true))
        {
            transform.position = Vector3.Slerp(target,transform.position,0.1f);
            bodys.useGravity = true;
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
