using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

    private int score = 0;
    //private int scoreToAdd = 100;
    public GameObject cardSpawner;

    CardPicker cardPicker;
    SpawnWeight weightSpawner;

    public GameObject lifeWeightSpawner;
    public GameObject workWeightSpawner;

    private CardType cardType;
    private WeightTypes cardWeight;
    private Card CardData;

    public GameObject lightWeight;
    public GameObject mediumWeight;
    public GameObject heavyWeight;

    private void Awake()
    {
        KeepScore();
    }
    // Start is called before the first frame update
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

        cardPicker.ChooseCard();

    }

    public void GetCardData()
    {
       CardData =cardSpawner.GetComponentInChildren<Card>();
        cardWeight = CardData.weight;
        cardType = CardData.cardType;

        int cardscore = CardData.score;
        score += cardscore;
        
        Invoke("DelayChossingCard", 1f);
    }

    private GameObject SelectWeight()
    {
        if(cardWeight == WeightTypes.Light)
        {
            return lightWeight;
        } else if( cardWeight == WeightTypes.Medium)
        {
            return mediumWeight;
        }
        else
        {
            return heavyWeight;
        }
    }

    public void onClickYesButton()
    {
        GetCardData();

        if (cardType == CardType.Life)
        { 
            weightSpawner.SpawnObject(SelectWeight(), lifeWeightSpawner);
        }
        else
        {
            weightSpawner.SpawnObject(SelectWeight(), workWeightSpawner);
        }
    }


    public void onClickNoButton()
    {
        GetCardData();

        if (cardType == CardType.Work)
        {
            weightSpawner.SpawnObject(SelectWeight(), lifeWeightSpawner);
        }
        else
        {
            weightSpawner.SpawnObject(SelectWeight(), workWeightSpawner);
        }

    }

    private void DelayChossingCard()
    {
        cardPicker.ChooseCard();
    }

    private void KeepScore()
    {
        DontDestroyOnLoad(gameObject);
    }

    //public void AddToScore()
    //{
    //    score += scoreToAdd;
    //    //scoreText.text = score.ToString();
    //}

    public int GetScore()
    {
        return score;
    }

    public void EndGame()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }


}
