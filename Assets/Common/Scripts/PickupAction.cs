using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PickupAction : PickupBase
{
    public UnityEvent action;
    
    protected override void OnPickup()
    {
        action.Invoke();
        
        DestroyPickup();
    }

}
