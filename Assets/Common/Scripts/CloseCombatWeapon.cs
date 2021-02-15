using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CloseCombatWeapon : MonoBehaviour
{
    public string buttonName = "Fire1";
    public float attackTime = 1;
    public Collider hitBox;

    private bool _attacking;

    private void Start()
    {
        hitBox.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (!Input.GetButtonDown(buttonName) || _attacking) return;
        hitBox.gameObject.SetActive(true);
        _attacking = true;
        Invoke(nameof(DisableHitBox), attackTime);
    }

    private void DisableHitBox()
    {
        hitBox.gameObject.SetActive(false);
        _attacking = false;
    }
}
