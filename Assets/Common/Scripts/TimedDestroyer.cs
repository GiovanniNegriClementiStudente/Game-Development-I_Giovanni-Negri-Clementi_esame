using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroyer : MonoBehaviour
{
    public float destroyAfterTime = 1f;

    public GameObject destroyVfx;
    
    void Start()
    {
        Invoke(nameof(SelfDestroy), destroyAfterTime);        
    }

    private void SelfDestroy()
    {
        if(destroyVfx != null)
            Instantiate(destroyVfx, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
