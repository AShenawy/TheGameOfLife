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
    public GameObject cardPicker;

    //public WeightTypes weight;

    // Start is called before the first frame update
    //void Start()
    //{
    //    if (weight  == small)
    //    {
    //        score = 100;
    //    }
    //    else if (weight == medium)
    //    {
    //        score = 200;
    //    }
    //    else if (weight == large)
    //    {
    //        score = 300;
    //    }
    //}

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
    //    }
    //}
}

public enum WeightTypes { Light, Medium, Heavy}
