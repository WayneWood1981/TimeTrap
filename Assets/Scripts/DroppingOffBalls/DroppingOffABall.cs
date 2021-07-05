using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DroppingOffABall : MonoBehaviour
{

    public GameObject player1ScoreBoard;

    AudioSource audioSource;
    public AudioClip retrievedBall;
    public AudioClip retrievedBonusBall;
    public int ballScore;
    public int bonusBallScore;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player1" || other.transform.tag == "Player2" || other.transform.tag == "Player3" || other.transform.tag == "Player4")
        {
            GameObject player = other.transform.gameObject;

            if (player.GetComponent<PickingUpBalls>().isCarryingABall)
            {
                
                if (player.GetComponent<PickingUpBalls>().ball.transform.tag == "BonusBall")
                {
                    audioSource.PlayOneShot(retrievedBonusBall);
                    Destroy(player.GetComponent<PickingUpBalls>().ball);
                    player.GetComponent<PickingUpBalls>().isCarryingABall = false;
                    player1ScoreBoard.GetComponent<Score>().playersCurrentScore += bonusBallScore;
                    player1ScoreBoard.GetComponent<Score>().UpdateScore();
                    Bonus(player);
                }
                else
                {
                    audioSource.PlayOneShot(retrievedBall);
                    Destroy(player.GetComponent<PickingUpBalls>().ball);
                    player.GetComponent<PickingUpBalls>().isCarryingABall = false;
                    player1ScoreBoard.GetComponent<Score>().playersCurrentScore += ballScore;
                    player1ScoreBoard.GetComponent<Score>().UpdateScore();
                }


            }
        }
        
        
        
    }

    void Bonus(GameObject player)
    {
        int randomNumber = Random.Range(1, 9);
        
        if (randomNumber <= 3)
        {
            player.GetComponent<PlayersBonus>().hasRWBonus = true;
            
        }
        else if (randomNumber <= 6 && randomNumber > 3)
        {
            player.GetComponent<PlayersBonus>().hasPPBonus = true;
            
        }
        else
        {
            player.GetComponent<PlayersBonus>().hasFFBonus = true;
            
        }

    }

}
