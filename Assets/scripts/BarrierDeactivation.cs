using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierDeactivation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("배리어 파괴");
        GameObject.Find("Barrier").GetComponent<SpriteRenderer>().enabled = false; 
    }
}
