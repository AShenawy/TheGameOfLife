using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeight : MonoBehaviour
{
    // This script spawns a weight game object with random X value.

    public GameObject weight;
    public GameObject spawner;
    public float minX;
    public float maxX;

    public void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        float spawnerX = spawner.transform.position.x + randomX;

        Instantiate(weight, new Vector2(spawnerX, spawner.transform.position.y), spawner.transform.rotation);
    }
}
