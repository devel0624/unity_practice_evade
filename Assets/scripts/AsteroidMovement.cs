using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{

    public Vector3 currentPosition;
    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

        currentPosition = transform.position;
            moveSpeed = Random.Range(0.1f, 0.3f);

    }

    // Update is called once per frame
    void Update()
    {
        currentPosition.y -= moveSpeed;

        if (currentPosition.y < -5)
        {
            currentPosition.y += 15;
            currentPosition.x = Random.Range(-8, 8);
            moveSpeed = Random.Range(0.1f, 0.3f);
        }

        transform.position = currentPosition;
    }
}
