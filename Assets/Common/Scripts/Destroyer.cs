using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject destroyVfx;
    
    public void DestroyObject()
    {
        if(destroyVfx != null)
            Instantiate(destroyVfx, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
