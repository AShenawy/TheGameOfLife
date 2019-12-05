using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // This script will contain the dialogue (string) and image (SpriteRenderer) for the card game object.
    // It will also contain what weight game object and score.

    public string dialogue;
    public int score;
    public WeightTypes weight;
    public CardType cardType;
}

public enum WeightTypes { Light, Medium, Heavy }
public enum CardType { Life, Work }
