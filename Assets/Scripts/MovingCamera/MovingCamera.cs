using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{

    PlayerManager playermanager;
    ArenaSpin arenaSpin;
    BallSpawning ballSpawn;
    Winner winner;

    [SerializeField] Transform cam;
    [SerializeField] Transform newCameraSpot;

    GameObject winningPlayer;
    public float moveCameraSpeed = 2f;
    public float rotationSpeed = 2f;

    public float moveCameraSpeedWon = 2f;
    public float rotationSpeedWon = 2f;

    public float speed = 5;

    public bool hasTriggered = false;

    private bool startToRotate = false;

    public bool hasWon = false;

    private void Awake()
    {
        //move = new Vector3(newCameraSpot.transform.position.x, newCameraSpot.transform.position.y, newCameraSpot.transform.position.z);
        cam = Camera.main.transform;
    }

    private void Start()
    {
        playermanager = FindObjectOfType<PlayerManager>();
        arenaSpin = FindObjectOfType<ArenaSpin>();
        ballSpawn = FindObjectOfType<BallSpawning>();
        winner = FindObjectOfType<Winner>();
    }


    private void Update()
    {
        if (hasTriggered)
        {
            playermanager.HideCanvas();
            cameraMovePosition();
        }

        if (hasWon)
        {
            CameraMoveToWinner();
        }

        if (startToRotate)
        {
            cam.RotateAround(winningPlayer.transform.position, winningPlayer.transform.forward, Time.deltaTime * speed);
        }

    }

    private void cameraMovePosition()
    {
        //Camera.main.fieldOfView = 101f;

        cam.transform.position = Vector3.MoveTowards(cam.transform.position, newCameraSpot.position, Time.deltaTime * moveCameraSpeed);
        
        cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, newCameraSpot.rotation, rotationSpeed * Time.deltaTime);

        if (cam.transform.position == newCameraSpot.position)
        {
            hasTriggered = false;
            playermanager.gameHasStarted = true;
            ballSpawn.SpawnNewBalls();
            playermanager.isInLobbyScreen = false;
            arenaSpin.hasStartedSpin = false;
        }

    }

    private void CameraMoveToWinner()
    {
        winningPlayer = winner.GetPlayer();
        Transform camPos = winningPlayer.transform.Find("WinnerCamPos").transform;

        cam.transform.position = Vector3.MoveTowards(cam.transform.position, camPos.position, Time.deltaTime * moveCameraSpeedWon);

        cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, camPos.transform.rotation, rotationSpeedWon * Time.deltaTime);

        if (cam.transform.position == newCameraSpot.position)
        {
            startToRotate = true;
            
        }
    }


}
