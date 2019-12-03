using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // This script will contain the dialogue (string) and image (SpriteRenderer) for the card game object.
    // It will also contain what weight game object and score.
    // 
    public WeightTypes weight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public enum WeightTypes { Light, Medium, Heavy}
