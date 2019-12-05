using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        if (gm == null)
            gm = this.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame()
    {
        print("The game is over");
    }
}
