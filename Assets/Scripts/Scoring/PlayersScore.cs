using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersScore : MonoBehaviour
{

    public float playersScore;

    Score score;

    GameObject scoreTransform;
    // Start is called before the first frame update
    void Start()
    {

        switch (this.transform.tag)
        {
            case "Player1":
                scoreTransform = GameObject.Find("Player1Score");
                break;
            case "Player2":
                scoreTransform = GameObject.Find("Player2Score");
                break;
            case "Player3":
                scoreTransform = GameObject.Find("Player3Score");
                break;
            case "Player4":
                scoreTransform = GameObject.Find("Player4Score");
                break;

        }
        
        score = scoreTransform.GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        playersScore = score.playersCurrentScore;
    }
}
