using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerManager : MonoBehaviour
{

    PlayerManager playerManager;
    PlayerInputManager playerInputManager;
    ColourChange colourChange;
    Winner winner;
    

    
    AudioSource ac;
    public AudioClip[] audioClips;
    public Transform player1Start;
    public Transform player2Start;
    public Transform player3Start;
    public Transform player4Start;

    public Canvas uiCanvas;

    public Transform[] playerStartingPos;
    public Material[] playersMaterials;
    public GameObject[] holders;
    public GameObject[] psHolders;
    public GameObject[] psHolderFront;

    public Material player1Mat;
    public Material player2Mat;
    public Material player3Mat;
    public Material player4Mat;

    public int currentNumber = 0;

    public GameObject[] players;
    public int playerAmount;
    public int readyPlayers;
    public bool gameHasStarted;
    public bool gameHasEnded;

    public bool isInLobbyScreen;

    public Transform GAMEARENA;
    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        winner = GetComponent<Winner>();
        gameHasStarted = false;
        isInLobbyScreen = true;
        playerAmount = 0;
        readyPlayers = 0;
        playerInputManager = GetComponent<PlayerInputManager>();
        ac = GetComponent<AudioSource>();
        //playerInputManager.playerPrefab = players[currentNumber];
        colourChange = FindObjectOfType<ColourChange>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideCanvas()
    {
        uiCanvas.gameObject.SetActive(false);
    }

    public void UnHideCanvas()
    {
        uiCanvas.gameObject.SetActive(true);
    }

    public void BeginGamePlayerPosition(PlayerInput playerInput, int colour)
    {
        switch (playerInput.playerIndex)
        {

            case 0:
                GameObject player1 = GameObject.FindGameObjectWithTag("Player1");
                player1.transform.tag = "Player1";
                player1.transform.name = "Player1";
                player1.transform.position = playerStartingPos[colour].position;
                player1.GetComponentInChildren<SkinnedMeshRenderer>().material = playersMaterials[colour];
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
                SetGameObjectsActive(player1, colour);

                
                
                break;
            case 1:
                GameObject player2 = GameObject.FindGameObjectWithTag("Player2");
                player2.transform.tag = "Player2";
                player2.transform.name = "Player2";
                player2.transform.position = playerStartingPos[colour].position;
                player2.GetComponentInChildren<SkinnedMeshRenderer>().material = playersMaterials[colour];
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
                SetGameObjectsActive(player2, colour);
                

                break;
            case 2:
                GameObject player3 = GameObject.FindGameObjectWithTag("Player3");
                player3.transform.tag = "Player3";
                player3.transform.name = "Player3";
                player3.transform.position = playerStartingPos[colour].position;
                player3.GetComponentInChildren<SkinnedMeshRenderer>().material = playersMaterials[colour];
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
                SetGameObjectsActive(player3, colour);
                

                break;
            case 3:
                GameObject player4 = GameObject.FindGameObjectWithTag("Player4");
                player4.transform.tag = "Player4";
                player4.transform.name = "Player4";
                player4.transform.position = playerStartingPos[colour].position;
                player4.GetComponentInChildren<SkinnedMeshRenderer>().material = playersMaterials[colour];
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
                SetGameObjectsActive(player4, colour);
                

                break;
        }
    }

    private void SetGameObjectsActive(GameObject player, int colour)
    {
        switch (colour)
        {
            case 0:
                player.transform.Find("PsHolderPlayer2").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer3").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer4").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer2").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer3").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer4").gameObject.SetActive(false);
                player.transform.Find("p2Holder").gameObject.SetActive(false);
                player.transform.Find("p3Holder").gameObject.SetActive(false);
                player.transform.Find("p4Holder").gameObject.SetActive(false);
                break;
            case 1:
                player.transform.Find("PsHolderPlayer1").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer3").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer4").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer1").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer3").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer4").gameObject.SetActive(false);
                player.transform.Find("p1Holder").gameObject.SetActive(false);
                player.transform.Find("p3Holder").gameObject.SetActive(false);
                player.transform.Find("p4Holder").gameObject.SetActive(false);
                break;
            case 2:
                player.transform.Find("PsHolderPlayer1").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer2").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer4").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer1").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer2").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer4").gameObject.SetActive(false);
                player.transform.Find("p1Holder").gameObject.SetActive(false);
                player.transform.Find("p2Holder").gameObject.SetActive(false);
                player.transform.Find("p4Holder").gameObject.SetActive(false);
                break;
            case 3:
                player.transform.Find("PsHolderPlayer1").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer2").gameObject.SetActive(false);
                player.transform.Find("PsHolderPlayer3").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer1").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer2").gameObject.SetActive(false);
                player.transform.Find("PsHolderFrontPlayer3").gameObject.SetActive(false);
                player.transform.Find("p1Holder").gameObject.SetActive(false);
                player.transform.Find("p2Holder").gameObject.SetActive(false);
                player.transform.Find("p3Holder").gameObject.SetActive(false);
                break;
        }
    }

    public void OnPlayerjoined(PlayerInput playerInput)
    {
        colourChange.PlayerHasJoinedLobby(playerInput.playerIndex);
        playerAmount += 1;
        
        //currentNumber += 1;

        //playerInputManager.playerPrefab = players[currentNumber];
        switch (playerInput.playerIndex)
        {
            case 0:
                GameObject player1 = playerInput.gameObject;
                player1.transform.tag = "Player1";
                player1.transform.name = "Player1";
                player1.transform.parent = GAMEARENA;
                winner.players.Add(player1);
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
               
                
                break;
            case 1:
                GameObject player2 = playerInput.gameObject;
                player2.transform.tag = "Player2";
                player2.transform.name = "Player2";
                player2.transform.parent = GAMEARENA;
                winner.players.Add(player2);
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
               
                
                break;
            case 2:
                GameObject player3 = playerInput.gameObject;
                player3.transform.tag = "Player3";
                player3.transform.name = "Player3";
                player3.transform.parent = GAMEARENA;
                winner.players.Add(player3);
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
               
                
                break;
            case 3:
                GameObject player4 = playerInput.gameObject;
                player4.transform.tag = "Player4";
                player4.transform.name = "Player4";
                player4.transform.parent = GAMEARENA;
                winner.players.Add(player4);
                ac.PlayOneShot(audioClips[UnityEngine.Random.Range(0, audioClips.Length)]);
             
                
                break;
        }
    }

    
}
