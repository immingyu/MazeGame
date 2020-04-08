using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        //rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            //BreakBrick();
            rigid.AddForce(new Vector3(h * 1, 0, v * 1), ForceMode.VelocityChange);
            //transform.position = transform.position + new Vector3(0,0,0.5f);

            //gameObject.AddComponent<DWGDestroyer>();
        }
        else
        {
            rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
        }
    }

}
