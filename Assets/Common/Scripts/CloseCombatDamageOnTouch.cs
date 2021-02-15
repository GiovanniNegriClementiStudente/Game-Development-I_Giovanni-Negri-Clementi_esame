using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class CloseCombatDamageOnTouch : MonoBehaviour
{
    public int damage = 1;

    private Collider _collider;

    private void Start()
    {
        _collider = GetComponent<Collider>();
        _collider.isTrigger = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        var h = other.gameObject.GetComponent<Health>();
        if (h != null) h.Damage(damage);
    }
}
