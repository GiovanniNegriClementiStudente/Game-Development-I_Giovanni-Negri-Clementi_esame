using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupRangedWeapon : PickupBase
{
    public GameObject newWeaponPrefab;

    protected override void OnPickup()
    {
        var weapon = _pc.GetComponent<RangedWeapon>();
        if (weapon == null) return;

        weapon.weaponPrefab = newWeaponPrefab;
        
        DestroyPickup();
    }
}
