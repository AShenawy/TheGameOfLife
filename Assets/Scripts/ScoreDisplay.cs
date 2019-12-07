using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    Text scoreText;
    //GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<Text>();
       //GameManager.gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = GameManager.gm.GetScore().ToString();
    }
}
