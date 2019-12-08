using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

    //Game manager have a control of the entire game and its behaviour, managing the card and the score.
    //Disable buttons interactable functionality,spawning card weights, changing the bodyType of the BalanceBody.
public class GameManager : MonoBehaviour
{
    // Make a copy of GameManager to be accessible by other scripts
    public static GameManager gm;

    [Header("BodyBalance")]
    [SerializeField] private GameObject balanceBody;

    [Header("Spawners")]
    [SerializeField] private GameObject cardSpawner;
    [SerializeField] private GameObject lifeWeightSpawner;
    [SerializeField] private GameObject workWeightSpawner;

    [Header("Card Weights")]
    [SerializeField] private GameObject lightWeight;
    [SerializeField] private GameObject mediumWeight;
    [SerializeField] private GameObject heavyWeight;

    [Header("Game Buttons")]
    [SerializeField] private Button yesButton;
    [SerializeField] private Button noButton;


    //Caching
    private CardPicker cardPicker;
    private SpawnWeight weightSpawner;

    //Card info
    private CardType cardType;
    private WeightTypes cardWeight;
    private Card cardData;

    private int score = 0;
    private int clickCounter;
    private bool isKinematic = true;


    private void Awake()
    {
        KeepScore();
    }

    void Start()
    {
        if (gm == null)
            gm = this.GetComponent<GameManager>();

        if (!cardPicker)
        {
            cardPicker = FindObjectOfType<CardPicker>();
        }

        if (!weightSpawner)
        {
            weightSpawner = FindObjectOfType<SpawnWeight>();
        }

        score = 0;

        // Freeze the balance bar at first try so the game isn't lost
        balanceBody.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

        cardPicker.ChooseCard();
    }


    public void onClickYesButton()
    {
        clickCounter++;

        MakeBalanceBarDynamic();

        GetCardData();

        if (cardType == CardType.Life)
        { 
            weightSpawner.SpawnObject(SelectCardWeight(), lifeWeightSpawner);
        }
        else
        {
            weightSpawner.SpawnObject(SelectCardWeight(), workWeightSpawner);
        }
    }


    public void onClickNoButton()
    {
        clickCounter++;

        MakeBalanceBarDynamic();

        GetCardData();

        if (cardType == CardType.Work)
        {
            weightSpawner.SpawnObject(SelectCardWeight(), lifeWeightSpawner);
        }
        else
        {
            weightSpawner.SpawnObject(SelectCardWeight(), workWeightSpawner);
        }
    }

    //gets current card data after clicking Yes/no buttons
    public void GetCardData()
    {
        cardData = cardSpawner.GetComponentInChildren<Card>();
        cardWeight = cardData.weight;
        cardType = cardData.cardType;

        int cardscore = cardData.score;
        score += cardscore;

        yesButton.GetComponent<Button>().interactable = false;
        noButton.GetComponent<Button>().interactable = false;

        // The next card is delayed by 1 second to allow time for the weight to drop and the player to notice the card
        // is changed. Also the yes/no buttons will be inactive during this time to prevent spamming
        Invoke("DelayChoosingCard", 1f);
    }

    private GameObject SelectCardWeight()
    {
        if (cardWeight == WeightTypes.Light)
        {
            return lightWeight;
        }
        else if (cardWeight == WeightTypes.Medium)
        {
            return mediumWeight;
        }
        else
        {
            return heavyWeight;
        }
    }

    //Needed when clickCounter = 2
    private void MakeBalanceBarDynamic()
    {
        if (clickCounter == 2 && isKinematic)
        {
            balanceBody.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            isKinematic = false;
        }
    }

    private void DelayChoosingCard()
    {
        cardPicker.ChooseCard();

        //enable buttons functionality
        yesButton.GetComponent<Button>().interactable = true;
        noButton.GetComponent<Button>().interactable = true;
    }

    //Keep a hold of the current score in case of GameOver
    private void KeepScore()
    {
        DontDestroyOnLoad(gameObject);
    }

    public int GetScore()
    {
        return score;
    }

    public void EndGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    //should be called on MainMenu scene to destroy the current GameManager and resets the game
    public void ResetGame()
    {
        Destroy(gameObject);
    }

}
