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



    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        movingCamera = FindObjectOfType<MovingCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (players.Count == 1 && playerManager.gameHasStarted)
        {
            playerManager.gameHasStarted = false;
            movingCamera.hasWon = true;

            winnerCanvas.gameObject.SetActive(true);
            winningText.text = GetPlayer().transform.tag + " WINS!";
            playerManager.gameHasEnded = true;
        }

        if (players.Count == 0 && playerManager.gameHasStarted)
        {

        }
        
    }

    public GameObject GetPlayer()
    {
        return players[0];
    }
}
