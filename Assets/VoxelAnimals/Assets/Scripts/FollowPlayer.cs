using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class FollowPlayer : MonoBehaviour
{

    public Transform Player;
    private float aggroRange = 15f;
    private NavMeshAgent navMeshAgent;


    // Start is called before the first frame update
    void Start()
    {

        navMeshAgent = GetComponent<NavMeshAgent>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, Player.position) < aggroRange)

        {

            navMeshAgent.isStopped = false;

            navMeshAgent.SetDestination(Player.position);

        }

        else

        {

            navMeshAgent.isStopped = true;

        }

    }
}
