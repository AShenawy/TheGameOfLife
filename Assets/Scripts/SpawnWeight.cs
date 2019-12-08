using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWeight : MonoBehaviour
{
    // This script spawns a weight game object with random X value.

    
    public float minX = -0.5f;
    public float maxX = 0.5f;
    public AudioClip[] spawnSFX;
    public SoundManager soundMan;

    private GameObject weight;
    private GameObject spawner;

    public void SpawnObject(GameObject weight, GameObject spawner)
    {
        // make a random horizontal value each time and set it relative to spawner X position
        float randomX = Random.Range(minX, maxX);
        float spawnerX = spawner.transform.position.x + randomX;

        Instantiate(weight, new Vector2(spawnerX, spawner.transform.position.y), spawner.transform.rotation);

        // Play the instantiated object's sound effect
        if (soundMan)
        {
            // Play a random sound from list of SFX's
            int i = Random.Range(0, spawnSFX.Length);
            soundMan.PlaySFX(spawnSFX[i]);
        }
    }
}
