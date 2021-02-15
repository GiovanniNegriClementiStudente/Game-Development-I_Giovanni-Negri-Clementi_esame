using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMoveTo : MonoBehaviour
{
    public Transform target;

    private NavMeshAgent _agent;
    
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.destination = target.position;
    }
    
    public void SetTarget(Transform t)
    {
        target = t;
        _agent.destination = target.position;
    }

}
