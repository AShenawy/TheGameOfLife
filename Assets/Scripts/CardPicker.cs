using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

    // This script creates 2 lists for the cards. It picks a random card from the active list and then removes
    // it so it isn't picked twice. Once all cards are picked the active list will be refilled from the cardlist
public class CardPicker : MonoBehaviour
{
    public List<GameObject> cardList;
    public GameObject cardSpawner;
    public Text textArea;
    public List<GameObject> activeList;

    private GameObject activeCard;
    private GameObject pickedCard;

    // Start is called before the first frame update
    void Start()
    {
        FillActiveList();

        ChooseCard();
    }
    
    public void ChooseCard()
    {
        if (activeList.Count > 0)
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

            if (activeList.Count <= 0)
            {
                FillActiveList(); // active list is empty and needs to be refilled
            }
        }
    }

    void FillActiveList()
    {
        // Fill the active list with cards in the card list
        foreach (var item in cardList)
        {
            activeList.Add(item);
        }
    }
}
