using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickupCloseCombatWeapon : PickupBase
{
    public int newDamage = 1;
    
    public UnityEvent pickupAction;

    protected override void OnPickup()
    {
        var weapon = _pc.GetComponent<CloseCombatWeapon>();
        if (weapon == null) return;

        var dam = weapon.hitBox.gameObject.GetComponent<CloseCombatDamageOnTouch>();
        if (dam == null) return;

        dam.damage = newDamage;
        pickupAction.Invoke();
        
        DestroyPickup();
    }
}
