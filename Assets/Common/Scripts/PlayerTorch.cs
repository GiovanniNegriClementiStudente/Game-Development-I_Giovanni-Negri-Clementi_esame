using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Collider))]
public class PlayerTorch : MonoBehaviour
{

    private float _startingSpeed;

    public float speedMalus = 0;

    private void Start()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        NavMeshAgent nma = other.gameObject.GetComponent<NavMeshAgent>();
        if (nma == null) return;
        _startingSpeed = nma.speed;
        nma.speed = speedMalus;
    }

    private void OnTriggerExit(Collider other)
    {
        NavMeshAgent nma = other.gameObject.GetComponent<NavMeshAgent>();
        if (nma == null) return;
        nma.speed = _startingSpeed;
    }
}
