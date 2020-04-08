using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class info_test : MonoBehaviour
{
    Timer timer = GameObject.Find("Cube").GetComponent<Timer>();
    public float[] data = new float[3];
    void Start()
    {
        data[0] = timer.data[0];
        data[1] = timer.data[1];
        data[2] = timer.data[2];
    }

    
    void Update()
    {
        data[0] = timer.data[0];
        Debug.Log(data[0]);
    }
}
