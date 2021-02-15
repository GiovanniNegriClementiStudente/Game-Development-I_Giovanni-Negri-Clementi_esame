using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class PickupBase : MonoBehaviour
{
    private Collider _collider;

    protected PlayerController _pc;

    public GameObject pickupVfx;
    
    void Start()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        _pc = other.gameObject.GetComponent<PlayerController>();
        if (_pc == null) return;
        OnPickup();
    }

    protected virtual void OnPickup()
    {
        
    }

    protected virtual void DestroyPickup()
    {
        if (pickupVfx != null) Instantiate(pickupVfx, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
