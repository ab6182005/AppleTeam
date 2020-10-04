using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public int i = 0;
    float randomX;

    public int randX;

    Rigidbody bodys;
    GameObject Player;
    GameObject button;
    GameObject score;
    PlayerMovement playermovement;
    ButtonEvent buttonevent;
    ScoreManager scoremanager;


    public void Start()
    {
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
        randX = Random.Range(1, 3);

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

        if ((Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1)))
        {

            int whatToSpawn = Random.Range(1, 5);
            randX = Random.Range(1, 3);



            if (randX == 1)
            {
                randomX = 1.5f;

            }
            else
            {
                randomX = 3;
                
            }

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

        bodys = transform.GetChild(i).GetComponent<Rigidbody>();
        bodys.isKinematic = false;
            
        i++;
    }
    //(Input.GetMouseButtonUp(0) || Input.GetMouseButtonUp(1))

}
}
