using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardPicker : MonoBehaviour
{
    // This script will have 2 lists for the cards. It will pick a random card from
    // first list, spawn it in the game screen and store it in second list.
    // When first list is empty, switch lists

    public List<GameObject> CardList;
    public GameObject ActiveCard;
    public GameObject PickedCard;
    public GameObject CardSpawner;
    public Text textArea;
    public List<GameObject> ActiveList;


    // Start is called before the first frame update
    void Start()
    {
        foreach (var item in CardList)
        {
            ActiveList.Add(item);
        }
        ChooseCard();

    }
    
    public void ChooseCard()
    {
        if (ActiveList.Count >0)
        {
            if (ActiveCard != null)
            {
                Destroy(ActiveCard.gameObject);
            }
            PickedCard = ActiveList[Random.Range(0, ActiveList.Count)]; // Choose random from list.,
            ActiveCard = Instantiate(PickedCard, CardSpawner.transform);
            
            textArea.text = PickedCard.GetComponent<Card>().dialogue;
            ActiveList.Remove(PickedCard);
            if ( ActiveList.Count == 0)
            {
                foreach (var item in CardList)
                {
                    ActiveList.Add(item);
                }
            }

        }


    }
}
