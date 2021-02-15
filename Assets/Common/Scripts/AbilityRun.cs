using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerController))]
public class AbilityRun : AbstractAbility
{
    public float speedMultiplier = 1.5f;

    private float _baseSpeed;
    private float _runSpeed;
    private PlayerController _controller;
    
    private void Start()
    {
        _controller = GetComponent<PlayerController>();
        _baseSpeed = _controller.speed;
        _runSpeed = _baseSpeed * speedMultiplier;
    }

    protected override void ExecuteAbility()
    {
        _controller.speed = _runSpeed;
    }

    protected override void ResetAbility()
    {
        _controller.speed = _baseSpeed;
    }
}
