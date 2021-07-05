using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickingUpBalls : MonoBehaviour
{
    PlayersBonus playerBonus;

    public Transform pickedUpBallPosition;

    public GameObject ball;

    AudioSource audioSource;

    public AudioClip ballPickUp;

    private string whichBall;

    public bool isCarryingABall;

    private void Start()
    {
        playerBonus = GetComponent<PlayersBonus>();
        audioSource = GetComponent<AudioSource>();
        
    }

    public void GetWhichBall()
    {
        switch (GetPlayerTag())
        {
            case "Player1":
                int pb = playerBonus.currentColourNumber;
                whichBall = GetNameOfBall(pb);
                
                break;
            case "Player2":
                int pb1 = playerBonus.currentColourNumber;
                whichBall = GetNameOfBall(pb1);
                
                break;
            case "Player3":
                int pb2 = playerBonus.currentColourNumber;
                whichBall = GetNameOfBall(pb2);
                break;
            case "Player4":
                int pb3 = playerBonus.currentColourNumber;
                whichBall = GetNameOfBall(pb3);
                break;

        }
    }

    private string GetNameOfBall(int currentColour)
    {
        switch (currentColour)
        {
            case 0:
                return "GreenBall";
            case 1:
                return "PurpleBall";
                
            case 2:
                return "OrangeBall";
                
            case 3:
                return "BlueBall";
                
        }
        return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == whichBall && !isCarryingABall)
        {

            ball = other.transform.gameObject;
            other.transform.parent = pickedUpBallPosition;
            other.transform.GetComponent<Rigidbody>().useGravity = false;
            other.transform.GetComponent<Rigidbody>().detectCollisions = false;
            audioSource.PlayOneShot(ballPickUp);
            isCarryingABall = true;

        }
        else if (other.transform.tag == "BonusBall" && !isCarryingABall)
        {

            ball = other.transform.gameObject;
            other.transform.parent = pickedUpBallPosition;
            other.transform.GetComponent<Rigidbody>().useGravity = false;
            other.transform.GetComponent<Rigidbody>().detectCollisions = false;
            audioSource.PlayOneShot(ballPickUp);

            isCarryingABall = true;

        }

    }

    private void Update()
    {
        if (isCarryingABall)
        {
            ball.transform.position = pickedUpBallPosition.position;
        }
    }

    private string GetPlayerTag()
    {
        return this.transform.tag;
    }

    
}
