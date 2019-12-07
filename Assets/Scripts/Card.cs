using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // This script will contain the dialogue (string) and image (SpriteRenderer) for the card game object.
    // It will also contain what weight game object and score.
    // 

    public string dialogue;
    public int score;
    public WeightTypes weight;
    public CardType cardType;

    //Start is called before the first frame update
    void Start()
    {
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
