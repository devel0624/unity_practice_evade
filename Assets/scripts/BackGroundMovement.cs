using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMovement : MonoBehaviour
{

    float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = -0.01f;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, moveSpeed, 0);

        if(transform.position.y < -10){
            transform.Translate(0, 20, 0);
        }
        
    }
}
