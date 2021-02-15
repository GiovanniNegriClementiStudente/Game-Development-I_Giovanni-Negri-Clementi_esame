using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[RequireComponent(typeof(NavMeshAgent))]
[RequireComponent(typeof(Collider))]
public class AIPatrol : MonoBehaviour
{

    private Transform _target;

    private NavMeshAgent _agent;
    private Collider _collider;

    public Transform[] waypoints;

    private bool _isPatrolling;

    public UnityEvent activationAction;
    
    void Start()
    {
        _isPatrolling = true;
        _agent = GetComponent<NavMeshAgent>();
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
        GetNextWaypoint();
    }

    private void GetNextWaypoint()
    {
        _target = waypoints[Random.Range(0, waypoints.Length)];
    }
    
    void Update()
    {
        var d = Vector3.Distance(transform.position, _target.position);
        if (_isPatrolling && d < 1.5f)
        {
            GetNextWaypoint();
        }

        _agent.destination = _target.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerController pc = other.gameObject.GetComponent<PlayerController>();
        if (pc == null) return;
        _isPatrolling = false;
        _target = other.transform;
        activationAction.Invoke();
    }
}
