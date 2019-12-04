using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPicker : MonoBehaviour
{
    // This script will have 2 lists for the cards. It will pick a random card from
    // first list, spawn it in the game screen and store it in second list.
    // When first list is empty, switch lists

    public List<GameObject> CardList;
    public List<GameObject> UsedCards;
    public GameObject ActiveCard;
    public GameObject PickedCard;
    public Card cardScript;
    //LAST CARD ekle, card degistirmeye onu kullan


    // Start is called before the first frame update
    void Start()
    {
        //GetCards();
        ChooseCard();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ChooseCard()
    {
        //PickedCard = CardList[Random.Range(0, CardList.Count)]; // Choose random from list.
        //print("first picked card " + PickedCard);
        //if (UsedCards.Contains(PickedCard))
        //{
        //    while (UsedCards.Contains(PickedCard))
        //    {
        //        PickedCard = CardList[Random.Range(0, CardList.Count)];
        //        print("next picked card " + PickedCard);
        //    }
        //    ActiveCard = PickedCard;
        //    print("Card active " + ActiveCard);
        //    UsedCards.Add(ActiveCard);
        //    print("Card added to UsedCard List " + ActiveCard);
        //    print(ActiveCard.GetComponent<Card>().dialogue); //Get text from cards script
        //    print(ActiveCard.GetComponent<Card>().score);
        //    //UsedCards.Add(PickedCard);
        //    //CardList.Remove(PickedCard);

        //}
        //else if (!UsedCards.Contains(PickedCard))
        //{
        //    ActiveCard = PickedCard;
        //    print("Card active " + ActiveCard);
        //    UsedCards.Add(ActiveCard);
        //    print("Card added to UsedCard List " + ActiveCard);
        //}
        if (CardList.Count >=1)
        {
            PickedCard = CardList[Random.Range(0, CardList.Count)]; // Choose random from list.
            UsedCards.Add(PickedCard);
            CardList.Remove(PickedCard);
            ActiveCard = PickedCard;
            print(ActiveCard.GetComponent<Card>().dialogue); //Get text from cards script
            print(ActiveCard.GetComponent<Card>().score);
        }
        else if (UsedCards.Count >= 1)
        {
            PickedCard = UsedCards[Random.Range(0, UsedCards.Count)]; // Choose random from list.
            CardList.Add(PickedCard);
            UsedCards.Remove(PickedCard);
            ActiveCard = PickedCard;
            print(ActiveCard.GetComponent<Card>().dialogue); //Get text from cards script
            print(ActiveCard.GetComponent<Card>().score);
        }

    }

    //public void ActivateCard()
    //{

    //}
}
