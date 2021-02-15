using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;

    public Transform spawnPoint;
    public void Spawn()
    {
        var prefab = prefabs[Random.Range(0, prefabs.Length)];
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
