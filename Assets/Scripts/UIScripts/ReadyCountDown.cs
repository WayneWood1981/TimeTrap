using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ReadyCountDown : MonoBehaviour
{

    PlayerManager playerManager;
    ColourChange colourChange;
    PlayersBonus[] playersBonus;
    MovingCamera movingCamera;
    ArenaSpin arenaSpin;
    PickingUpBalls[] pickingUpBalls;

    float currentTime;

    private bool enoughPlayersAreReady;
    private bool forceStop;

    public GameObject currentTimer;

    //public TextMeshPro tmp;

    private TMP_Text tmp;
    // Start is called before the first frame update
    void Start()
    {
        
        playerManager = FindObjectOfType<PlayerManager>();
        colourChange = FindObjectOfType<ColourChange>();
        playersBonus = FindObjectsOfType<PlayersBonus>();
        arenaSpin = FindObjectOfType<ArenaSpin>();
        tmp = currentTimer.GetComponent<TMP_Text>();
        currentTime = 5;
        movingCamera = FindObjectOfType<MovingCamera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (playerManager.readyPlayers == playerManager.playerAmount && playerManager.playerAmount != 0 && forceStop == false)
        {
            enoughPlayersAreReady = true;
        }
        else
        {
            enoughPlayersAreReady = false;
        }

        if (enoughPlayersAreReady)
        {
            StartCountDOwn();
            
        }
        else
        {
            StopCountDown();
        }
    }


    public void StartCountDOwn()
    {
        string time = Mathf.RoundToInt(currentTime).ToString();
        currentTime -= Time.deltaTime;
        
        tmp.SetText(time);
        tmp.text = time;
        tmp.SetAllDirty();
        tmp.ForceMeshUpdate(true);

        if(currentTime <= 0)
        {
            
            tmp.text = "GO!";
            tmp.SetAllDirty();
            tmp.ForceMeshUpdate(true);
            movingCamera.hasTriggered = true;
            arenaSpin.hasStartedSpin = true;
            pickingUpBalls = FindObjectsOfType<PickingUpBalls>();
            foreach (PickingUpBalls p in pickingUpBalls)
            {
                p.GetWhichBall();
            }
            Invoke("StopCountDown", 3);
            
            enoughPlayersAreReady = false;
            forceStop = true;
        }
    }


    private void StopCountDown()
    {
        currentTime = 5;
        
        tmp.SetText("");
        tmp.text = "";
        tmp.SetAllDirty();
        tmp.ForceMeshUpdate(true);
    }
}
