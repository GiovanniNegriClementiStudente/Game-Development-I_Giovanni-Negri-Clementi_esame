using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractAbility : MonoBehaviour
{
    public string buttonName = "Fire1";

    private bool _abilityEnabled = false;
    protected virtual void Update()
    {
        _abilityEnabled = Input.GetButton(buttonName);
        if (_abilityEnabled)
        {
            ExecuteAbility();
        }
        else
        {
            ResetAbility();
        }
    }

    protected virtual void ExecuteAbility()
    {
        
    }

    protected virtual void ResetAbility()
    {
        
    }

    
}
