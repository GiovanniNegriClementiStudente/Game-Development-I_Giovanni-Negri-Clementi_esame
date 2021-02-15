using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionTimer : MonoBehaviour
{

    public float minEventTime = 0;
    public float maxEventTime = 10;

    public UnityEvent action;
    
    private void Start()
    {
        StartTimer();
    }

    public void StartTimer()
    {
        StartCoroutine(nameof(TimeLoop));
    }

    public void StopTimer()
    {
        StartCoroutine(nameof(TimeLoop));
    }
    
    private IEnumerator TimeLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minEventTime, maxEventTime));
            action.Invoke();
        }   
    }
}
