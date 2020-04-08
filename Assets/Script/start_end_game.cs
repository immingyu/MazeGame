using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_end_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "start")
        {
            Debug.Log("시작"); 
        }
        else if (collision.gameObject.name == "end")
        {
            Debug.Log("종료");
        }
    }
}
