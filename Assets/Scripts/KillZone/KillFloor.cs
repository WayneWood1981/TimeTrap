using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{

    public Transform player1Start;
    public Transform player2Start;
    public Transform player3Start;
    public Transform player4Start;

    public Transform GameArena;

    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;

    public float respawnTime;

    GameObject playerWhoFell;
    AudioSource ac;
    public AudioClip[] audioClips;

    private void Start()
    {
        ac = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        playerWhoFell = other.transform.gameObject;
        switch (other.transform.tag)
        {
            
            case "GreenBall":
                Destroy(other.gameObject);
                break;
            case "PurpleBall":
                Destroy(other.gameObject);
                break;
            case "OrangeBall":
                Destroy(other.gameObject);
                break;
            case "BlueBall":
                Destroy(other.gameObject);
                break;
            case "BonusBall":
                Destroy(other.gameObject);
                break;
            case "Player1":
                Respawn(playerWhoFell, player1Start);
                break;
            case "Player2":
                Respawn(playerWhoFell, player2Start);
                break;
            case "Player3":
                Respawn(playerWhoFell, player3Start);
                break;
            case "Player4":
                Respawn(playerWhoFell, player4Start);
                break;
        }

    }


    void Respawn(GameObject player, Transform pos)
    {
        player.GetComponentInChildren<Animator>().SetBool("isFalling", false);
        player.transform.position = pos.position;
        player.transform.parent = GameObject.Find("GAMEARENA").transform;
        player.GetComponent<PlayerMovement>().downwardForce = 0.1f;
        ac.PlayOneShot(audioClips[Random.Range(0, audioClips.Length)]);
    }
    
}
