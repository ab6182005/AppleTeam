using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomPlatform : MonoBehaviour
{
    [SerializeField] private List<GameObject> platforms;
    [SerializeField] private GameObject platforms_parent;

    [SerializeField] private GameObject cube1;
    [SerializeField] private GameObject cube2;
    [SerializeField] private GameObject cube3;
    [SerializeField] private GameObject cube4;

    float X = 0;
    float Y = 0;
    float secondX;
    int i = 0;
    float randomX;

    Rigidbody bodys;
    GameObject Player;
    GameObject button;
    GameObject score;
    PlayerMovement playermovement;
    ButtonEvent buttonevent;
<<<<<<< HEAD
    public Text score;
    private int scorePoint;
=======
    ScoreManager scoremanager;
>>>>>>> def7a7dc905d37d8d1371c4677eea2c29117a9f7

    public void Start()
    {
        scorePoint = 0;
        bodys = GetComponent<Rigidbody>();

        Player = GameObject.Find("Player");
        playermovement = Player.GetComponent<PlayerMovement>();

        button = GameObject.Find("Button");
        buttonevent = button.GetComponent<ButtonEvent>();

        score = GameObject.Find("Manager");
        scoremanager = score.GetComponent<ScoreManager>();


        int whatToSpawn = Random.Range(1, 5);

        switch (whatToSpawn)     // 플랫폼 개수만큼 만들어주기
        {
            case 1:
                GameObject clone = Instantiate(cube1, new Vector3(-2f, -10f, 0f), Quaternion.identity);
                clone.transform.parent = platforms_parent.transform;
                platforms.Add(clone);
                break;
            case 2:
                GameObject clone2 = Instantiate(cube2, new Vector3(-2f, -10f, 0f), Quaternion.identity);
                clone2.transform.parent = platforms_parent.transform;
                platforms.Add(clone2);
                break;
            case 3:
                GameObject clone3 = Instantiate(cube3, new Vector3(-2f, -10f, 0f), Quaternion.identity);
                clone3.transform.parent = platforms_parent.transform;
                platforms.Add(clone3);
                break;
            case 4:
                GameObject clone4 = Instantiate(cube4, new Vector3(-2f, -10f, 0f), Quaternion.identity);
                clone4.transform.parent = platforms_parent.transform;
                platforms.Add(clone4);
                break;
        }

        secondX = secondPlatform();
    }

    public void Update()
    {
        makePlatform();
    }

    public float secondPlatform()
    {
        int whatToSpawn = Random.Range(1, 5);
        int randX = Random.Range(1, 3);

        if (randX == 1)
        {
            randomX = 1.5f;
        }
        else
        {
            randomX = 3;
        }

        switch (whatToSpawn)     // 플랫폼 개수만큼 만들어주기
        {
            case 1:
                GameObject clone = Instantiate(cube1, new Vector3(-2 + randomX, -9, 0f), Quaternion.identity);
                clone.transform.parent = platforms_parent.transform;
                platforms.Add(clone);
                break;
            case 2:
                GameObject clone2 = Instantiate(cube2, new Vector3(-2 + randomX, -9, 0f), Quaternion.identity);
                clone2.transform.parent = platforms_parent.transform;
                platforms.Add(clone2);
                break;
            case 3:
                GameObject clone3 = Instantiate(cube3, new Vector3(-2 + randomX, -9, 0f), Quaternion.identity);
                clone3.transform.parent = platforms_parent.transform;
                platforms.Add(clone3);
                break;
            case 4:
                GameObject clone4 = Instantiate(cube4, new Vector3(-2 + randomX, -9, 0f), Quaternion.identity);
                clone4.transform.parent = platforms_parent.transform;
                platforms.Add(clone4);
                break;
        }

        return -2 + randomX;
    }

    public void makePlatform()
    {
        int whatToSpawn = Random.Range(1, 5);
        int randX = Random.Range(1, 3);

        if(randX == 1)
        {
            randomX = 1.5f;
        }
        else
        {
            randomX = 3;
        }

        if ((buttonevent.leftclick || buttonevent.rightclick) && playermovement.isGround == true) {
           
            scoremanager.setScore(1);
            switch (whatToSpawn)     // 플랫폼 개수만큼 만들어주기
            {
                case 1:
                    GameObject clone = Instantiate(cube1, new Vector3(randomX + secondX + X, -8 + Y, 0), Quaternion.identity);
                    clone.transform.parent = platforms_parent.transform;
                    platforms.Add(clone);
                    break;
                case 2:
                    GameObject clone2 = Instantiate(cube2, new Vector3(randomX + secondX + X, -8 + Y, 0), Quaternion.identity);
                    clone2.transform.parent = platforms_parent.transform;
                    platforms.Add(clone2);
                    break;
                case 3:
                    GameObject clone3 = Instantiate(cube3, new Vector3(randomX + secondX + X, -8 + Y, 0), Quaternion.identity);
                    clone3.transform.parent = platforms_parent.transform;
                    platforms.Add(clone3);
                    break;
                case 4:
                    GameObject clone4 = Instantiate(cube4, new Vector3(randomX + secondX + X, -8 + Y, 0), Quaternion.identity);
                    clone4.transform.parent = platforms_parent.transform;
                    platforms.Add(clone4);
                    break;
            }
        X += randomX;
        Y += 1f;

<<<<<<< HEAD
        bodys = transform.GetChild(i).GetComponent<Rigidbody>();
        
        /*
        if (playermovement.isGround == true)
=======
        bodys = transform.GetChild(i).GetComponent<Rigidbody2D>();
        
        if (playermovement.isGround == false)
>>>>>>> def7a7dc905d37d8d1371c4677eea2c29117a9f7
        {
            bodys.isKinematic = true;
        }
<<<<<<< HEAD
        */
        bodys.isKinematic = false;
=======
        
>>>>>>> def7a7dc905d37d8d1371c4677eea2c29117a9f7

        i++;

        scorePoint += 1;
        score.text = "" + scorePoint;
        }
    //(Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))

}
}
