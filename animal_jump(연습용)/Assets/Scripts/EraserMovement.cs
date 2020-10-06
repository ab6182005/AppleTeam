using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserMovement : MonoBehaviour
{

    GameObject Player;
    PlayerMovement playermovement;
    public float speed=0.9f;
    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        playermovement = Player.GetComponent<PlayerMovement>();


        if (playermovement.isGround == true)
        {
            Invoke("Update", 30);
        }

    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("5초 지남");
        Vector3 player = Player.transform.position;
        transform.position = Vector3.Lerp(transform.position, player, Time.deltaTime * speed);


    }

    public void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;
        if (other.CompareTag("Player"))
        {
            Debug.Log("GameOver");
        }

    }
}
