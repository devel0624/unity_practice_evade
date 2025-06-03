using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierActivation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("배리어 생성");
        GameObject.Find("Barrier").GetComponent<SpriteRenderer>().enabled = true; 
    }
}
