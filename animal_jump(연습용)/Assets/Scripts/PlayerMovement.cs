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
    public bool isGround=false;
    public object player;
    public bool temp;
    int i;
    int randX;
    

    GameObject platformparent;
    randomPlatform randomplatform;


    GameObject button;
    ButtonEvent buttonevent;




    // Start is called before the first frame update
    void Start()
    {
        platformparent = GameObject.Find("PlatformParent");
        randomplatform = platformparent.GetComponent<randomPlatform>();

        button = GameObject.Find("Button");
        buttonevent = button.GetComponent<ButtonEvent>();

        // myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        i = randomplatform.i;
        Rigidbody bodys = platformparent.transform.GetChild(i).gameObject.GetComponent<Rigidbody>();
        GameObject ChildGameObject0 = platformparent.transform.GetChild(i + 1).gameObject;

        GameObject target = ChildGameObject0.transform.Find("GameObject").gameObject;
        GameObject shortjump = ChildGameObject0.transform.Find("short").gameObject;
        GameObject longjump = ChildGameObject0.transform.Find("long").gameObject;

        Vector3 targetspot = target.transform.position;
        Vector3 shortspot = shortjump.transform.position;
        Vector3 longspot = longjump.transform.position;
        
       
        if ((buttonevent.leftclick==true) && (isGround == true))
        {
            

            if (randomplatform.randX == 1) 
            {
               
                transform.position = Vector3.Slerp(targetspot, transform.position, 0.1f);
                bodys.useGravity = true;
                isGround = false;

            }

            else
            {
                transform.position = Vector3.Slerp(shortspot, transform.position, 0.1f);
                isGround = false;                                                          
            }


        }

        if ((buttonevent.rightclick==true) && (isGround == true))
        {

            if (randomplatform.randX == 2) 
            {
                transform.position = Vector3.Slerp(targetspot, transform.position, 0.1f);
                bodys.useGravity = true;
                isGround = false;

            }


            else
            {
                
                transform.position = Vector3.Slerp(longspot, transform.position, 0.1f);
                isGround = false;

            }


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



