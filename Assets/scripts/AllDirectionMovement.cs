using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Vector3 playerPosition;

    int maxX;
    int minX;
    int maxY;
    int minY;

    void Start()
    {
        playerPosition.x = 0;
        playerPosition.y = -3;

        maxX = 9;
        minX = -9;
        maxY = 5;
        minY = -5;
    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.A))
            {
                playerPosition.x += -0.2f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                playerPosition.x += 0.2f;
            }

            if (Input.GetKey(KeyCode.W))
            {
                playerPosition.y += 0.2f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                playerPosition.y += -0.2f;
            }

            playerPosition.x = math.min(playerPosition.x, maxX);
            playerPosition.x = math.max(playerPosition.x, minX);

            playerPosition.y = math.min(playerPosition.y, maxY);
            playerPosition.y = math.max(playerPosition.y, minY);

            transform.position = playerPosition;   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("충돌 감지");

        bool barrierActivated = GameObject.Find("Barrier").GetComponent<SpriteRenderer>().enabled;

        if (!barrierActivated)
        {
            GameObject.Find("GameOverText").GetComponent<Text>().enabled = true;

            GetComponent<Rigidbody2D>().gravityScale = 0.02f;
            GetComponent<PlayerMovement>().enabled = false;
        }
    }

}
