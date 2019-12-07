using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPicker : MonoBehaviour
{
    // This script will have 2 lists for the cards. It will pick a random card from
    // first list, spawn it in the game screen and store it in second list.
    // When first list is empty, switch lists

    public List<GameObject> cardList;
    public GameObject cardSpawner;
    public Text textArea;
    public List<GameObject> activeList;

    private GameObject activeCard;
    private GameObject pickedCard;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in cardList)
        {
            activeList.Add(item);
        }

        ChooseCard();
    }
    
    public void ChooseCard()
    {
        if (activeList.Count >0)
        {
            // If there's already a card displayed on screen, destroy it
            if (activeCard != null)
            {
                Destroy(activeCard.gameObject);
            }

            // Pick a new card from the active list of cards
            pickedCard = activeList[Random.Range(0, activeList.Count)];
            activeCard = Instantiate(pickedCard, cardSpawner.transform);

            textArea.text = pickedCard.GetComponent<Card>().dialogue;
            activeList.Remove(pickedCard);
            if ( activeList.Count == 0)
            {
                foreach (var item in cardList)
                {
                    activeList.Add(item);
                }
            }
        }
    }
}
