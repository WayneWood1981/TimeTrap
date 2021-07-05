using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceNewPlayers : MonoBehaviour
{

    public int amountOfActivePlayers;

    public Transform player1Start;
    public Transform player2Start;
    public Transform player3Start;
    public Transform player4Start;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    // Start is called before the first frame update
    void Awake()
    {
       /* switch (amountOfActivePlayers)
        {
            case 1:
                GameObject newPlayer1 = Instantiate(player1, player1Start.position, player1Start.rotation);
                newPlayer1.transform.parent = this.transform;
                newPlayer1.GetComponent<Rigidbody>().drag = 30;
                break;
            case 2:
                GameObject newPlayer2 = Instantiate(player2, player2Start.position, player2Start.rotation);
                newPlayer2.transform.parent = this.transform;
                newPlayer2.GetComponent<Rigidbody>().drag = 30;
                break;
            case 3:
                GameObject newPlayer3 = Instantiate(player3, player3Start.position, player3Start.rotation);
                newPlayer3.transform.parent = this.transform;
                newPlayer3.GetComponent<Rigidbody>().drag = 30;
                break;
            case 4:
                GameObject newPlayer4 = Instantiate(player4, player4Start.position, player4Start.rotation);
                newPlayer4.transform.parent = this.transform;
                newPlayer4.GetComponent<Rigidbody>().drag = 30;
                break;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
