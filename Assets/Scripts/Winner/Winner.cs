using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Winner : MonoBehaviour
{

    PlayerManager playerManager;
    MovingCamera movingCamera;

    public Canvas winnerCanvas;
    public TMP_Text winningText;

    public List<GameObject> players;

    private bool isAWinner;

    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        movingCamera = FindObjectOfType<MovingCamera>();
        isAWinner = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (players.Count == 1 && playerManager.gameHasStarted)
        {
            if (!isAWinner)
            {
                Invoke("WinDelay", 1);

                isAWinner = true;
            }
            
        }

        if (players.Count == 0 && playerManager.gameHasStarted)
        {

        }
        
    }

    void WinDelay()
    {
        playerManager.gameHasStarted = false;
        movingCamera.hasWon = true;

        winnerCanvas.gameObject.SetActive(true);
        winningText.text = GetPlayer().transform.tag + " WINS!";
        playerManager.gameHasEnded = true;
    }

    public GameObject GetPlayer()
    {
        return players[0];
    }
}
