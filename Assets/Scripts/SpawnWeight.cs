using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeight : MonoBehaviour
{
    // This script spawns a weight game object with random X value.

    
    public float minX = -0.5f;
    public float maxX = 0.5f;

    private GameObject weight;
    private GameObject spawner;

    public void SpawnObject(GameObject weight, GameObject spawner)
    {
        float randomX = Random.Range(minX, maxX);
        float spawnerX = spawner.transform.position.x + randomX;

        Instantiate(weight, new Vector2(spawnerX, spawner.transform.position.y), spawner.transform.rotation);
    }
}
