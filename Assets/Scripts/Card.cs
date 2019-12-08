using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    // This script contains the information related to each card game object.
public class Card : MonoBehaviour
{
    [TextArea]
    public string dialogue;
    public WeightTypes weight;
    public CardType cardType;

    [HideInInspector]
    public int score;

    void Start()
    {
        // Set score for each weight type
        if (weight == WeightTypes.Light)
        {
            score = 100;
        }
        else if (weight == WeightTypes.Medium)
        {
            score = 200;
        }
        else if (weight == WeightTypes.Heavy)
        {
            score = 300;
        }
    }
}

public enum WeightTypes { Light, Medium, Heavy}
public enum CardType { Life, Work}
