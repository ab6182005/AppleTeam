using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{


    GameObject Player;
    PlayerMovement playermovement;
    public bool leftclick;
    public bool rightclick;

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
    }

    public void LeftButtonDown()
    {
        leftclick = true;
        playermovement.jump = true;

    }

    public void LeftButtonUp()
    {
        leftclick = false;
        playermovement.jump = false;
    }

    public void RightButtonDown()
    {
        rightclick = true;
        playermovement.doublejump = true;
    }
    public void RightButtonUp()
    {
        rightclick = false;
        playermovement.doublejump = false;
    }
}

