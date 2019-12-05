using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    // This script will contain the dialogue (string) and image (SpriteRenderer) for the card game object.
    // It will also contain what weight game object and score.
    // 

    public string dialogue;
    public SpriteRenderer cardImage;
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

    public void SetCardDetails(string text, SpriteRenderer image,int skor)
    {
        dialogue = text;
        cardImage = image;
        score = skor;
    }

    //public void ChangeCard()
    //{
    //    if (cardPicker.GetComponent<CardPicker>().ActiveCard.)
    //    {
    //Card pickerdeki last card'ı bulup karsılastır. Aynı degilse(degismisse) yenisinin detaylarını ekle.

    //  THIS IS IF IT DOESN'T WORK ON FIRST START

    //    }
    //}
}

public enum WeightTypes { Light, Medium, Heavy}
public enum CardType { Life, Work}
