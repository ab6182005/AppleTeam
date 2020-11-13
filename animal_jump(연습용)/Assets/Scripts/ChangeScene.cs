using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    GameObject Player;
    PlayerMovement playermovement;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        playermovement = Player.GetComponent<PlayerMovement>();

    }

    // Update is called once per frame
    void Update()
    {
        if (playermovement.gameover == true)
        {
            SceneManager.LoadScene("gameover");
        }
    }
}
