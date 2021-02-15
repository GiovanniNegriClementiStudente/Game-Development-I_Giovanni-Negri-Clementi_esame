using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AISeek : MonoBehaviour
{
    public Transform target;

    private NavMeshAgent _agent;

    public bool seekObjectOnCreation;

    public string objectName;
    
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        if (!seekObjectOnCreation || string.IsNullOrEmpty(objectName)) return;
        StartCoroutine(nameof(FindTarget));
    }

    private IEnumerator FindTarget()
    {
        target = null;
        while (target == null)
        {
            yield return new WaitForEndOfFrame();
            var go = GameObject.Find(objectName);
            Debug.Log(go);
            if (go != null) target = go.transform;
        }
    }

    private void Update()
    {
        if (target == null) return;
        _agent.destination = target.position;
    }

    public void SetTarget(Transform t)
    {
        target = t;
    }
}
