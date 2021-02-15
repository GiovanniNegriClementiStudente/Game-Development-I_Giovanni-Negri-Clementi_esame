using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : MonoBehaviour
{
    public string buttonName = "Fire1";

    public GameObject weaponPrefab;
    
    public Transform spawnPoint;
    
    protected void Spawn()
    {
        var prefab = weaponPrefab;
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
    
    private void Update()
    {
        if (Input.GetButtonDown(buttonName))
        {
            Spawn();
        }
    }

}
