using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script displays the player score during the game and also in the game over screen
public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.gm.GetScore().ToString();
    }
}
