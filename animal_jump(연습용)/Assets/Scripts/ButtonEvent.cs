using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{


    GameObject Player;
    PlayerMovement playermovement;
    public bool leftclick;
    public bool rightclick;
    public bool Click = false;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        playermovement = Player.GetComponent<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        //isGround = Physics2D.OverlapCircle(pos.position, checkRadius, islayer);
        Click = false;
    }

    public void LeftButtonDown()
    {
        Click = false;
        leftclick = true;
        playermovement.jump = true;
    }
    
    public void LeftButtonUp()
    {
        Click = true;
        leftclick = false;
        playermovement.jump = false;
    }


    public void RightButtonDown()
    {
        Click = false;
        rightclick = true;
        playermovement.doublejump = true;
    }

    public void RightButtonUp()
    {
        Click = true;
        rightclick = false;
        playermovement.doublejump = false;
    }

}

