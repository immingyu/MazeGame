using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player_Ctrl : MonoBehaviour
{
    private NavMeshAgent nv;
    public Transform targetTr;
   
    IEnumerator Start()
    {
        nv = GetComponent<NavMeshAgent>();

        yield return new WaitForSeconds(3.0f);

        nv.SetDestination(targetTr.position);
    }

    void Update()
    {
        nv.SetDestination(targetTr.position);
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("target"))
        {
            nv.isStopped = true;
        }
    }
}
