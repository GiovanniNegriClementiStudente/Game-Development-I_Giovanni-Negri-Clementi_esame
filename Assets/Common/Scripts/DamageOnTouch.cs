using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnTouch : MonoBehaviour
{
    public int damage = 1;
    
    private void OnCollisionEnter(Collision other)
    {
        var h = other.gameObject.GetComponent<Health>();
        if (h != null) h.Damage(damage);
        Destroy(gameObject);
    }
}
