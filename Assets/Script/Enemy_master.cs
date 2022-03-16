using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_master : MonoBehaviour
{

    public GameObject player; 
    public float Distance;

    public bool isAngered;

    public NavMeshAgent _agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(player.transform.position, this.transform.position);

        if(Distance <=5)
        {
            isAngered = true;
        }
        if(Distance > 5f)
        {
            isAngered = false; 
        }

        if(isAngered)
        {
            _agent.isStopped = false;
            
            _agent.SetDestination(player.transform.position);
        }
        if(!isAngered)
        {
            _agent.isStopped = true;
        }
    }
}
